// From http://www.antlr.org/grammar/1062280680642/MS_SQL_SELECT.html ,
// simplified & extended with other SQL commands.

grammar MacroScope;

options {
	language=CSharp2;
}

@lexer::namespace {
	MacroScope
}

@parser::namespace {
	MacroScope
}

@lexer::members {
	public override void ReportError(RecognitionException e)
	{
	}
}

@rulecatch {
}

statement returns [ IStatement value ] :
	i = insertStatement EOF { $value = $i.value; }
	| s = selectStatement EOF { $value = $s.value; }
	| u = updateStatement EOF { $value = $u.value; }
	| d = deleteStatement EOF { $value = $d.value; }
	;

insertStatement returns [ InsertStatement value ] :
	// WITH INSERT & INSERT TOP not supported
	INSERT { $value = new InsertStatement(); } ( INTO )?
		o = dbObject {
			$value.Table = $o.value;
		}
		// column names are technically optional, but we'll
		// require them, as good practice...
		LPAREN c = columnNameList RPAREN {
			$value.ColumnNames = $c.value;
		}
		VALUES LPAREN e = columnValueList RPAREN {
			$value.ColumnValues = $e.value;
		}
		// derived table & execute statement not supported
		// DataLoader won't use them
	;

selectStatement returns [ SelectStatement value ] :
	q = queryExpression { $value = new SelectStatement($q.value); }
	;

updateStatement returns [ UpdateStatement value ] :
	// WITH UPDATE & UPDATE TOP not supported
	UPDATE { $value = new UpdateStatement(); }
		o = dbObject { $value.Table = $o.value; }
		SET a = assignmentList {
			$value.Assignments = $a.value;
		}
		// UPDATE FROM not supported		
		( // cursors not supported
			w = whereClause { $value.Where = $w.value; }
		)?
		// options not supported
	;

deleteStatement returns [ DeleteStatement value ] :
	// WITH DELETE & DELETE TOP not supported
	DELETE { $value = new DeleteStatement(); } ( FROM )?
		o = dbObject { $value.Table = $o.value; }
		( // cursors not supported
			w = whereClause { $value.Where = $w.value; }
		)?
		// options not supported
	;
	
assignmentList returns [ Assignment value ] :
	a = assignment {
		$value = $a.value;
	} ( COMMA a = assignment {
			$value.Add($a.value);
		} )*
	;

assignment returns [ Assignment value ] :
	c = column ASSIGNEQUAL v = columnValue {
		$value = new Assignment($c.value, $v.value);
	}
	;

columnNameList returns [ AliasedItem value ] :
	c = column { $value = new AliasedItem($c.value); }
		( COMMA c = column {
			$value.Add(new AliasedItem($c.value));
		} )*
	;

columnValueList returns [ ExpressionItem value ] :
	v = columnValue {
		$value = new ExpressionItem($v.value);
	} ( COMMA v = columnValue {
			$value.Add(new ExpressionItem($v.value));
		} )*
	;

columnValue returns [ INode value ] :
	DEFAULT { $value = DefaultValue.Value; }
	| e = expression { $value = $e.value; }
	;

queryExpression returns [ QueryExpression value ] :
	s = subQueryExpression { $value = $s.value; } 
	( u = unionOperator
		s = subQueryExpression {
			$s.value.All = $u.value;
			$value.Add($s.value);
		}
	)*
	( o = orderByClause { $value.SetOrderBy($o.value); } )?
	;

subQueryExpression returns [ QueryExpression value ] :
	s = querySpecification  { $value = $s.value; }
	| LPAREN s = queryExpression RPAREN { $value = $s.value; }
	;

querySpecification returns [ QueryExpression value ] :
	s = selectClause { $value = $s.value; }
	( f = fromClause { $value.From = $f.value; } )?
	( w = whereClause { $value.Where = $w.value; } )?
	( g = groupByClause { $value.GroupBy = $g.value; }
		( h = havingClause { $value.GroupBy.Having = $h.value; } )?
	)?
	;

selectClause returns [ QueryExpression value ] :
	SELECT { $value = new QueryExpression(); }
	( ALL | DISTINCT { $value.Distinct = true; } )?
	(TOP Integer { $value.Top = int.Parse($Integer.text); } )?
	s = selectList { $value.SelectItems = $s.value; }
	;

whereClause returns [ IExpression value ] :
	WHERE c = searchCondition { $value = $c.value; }
	;

orderByClause returns [ OrderExpression value ] :
	ORDER BY
	e = orderExpression { $value = $e.value; }
	( COMMA e = orderExpression { $value.Add($e.value); } )*
	;

orderExpression returns [ OrderExpression value ] :
	e = expression { $value = new OrderExpression($e.value); }
	( ASC | DESC { $value.Asc = false; } )?
	;

groupByClause returns [ GroupByClause value ] :
	GROUP BY { $value = new GroupByClause(); }
		( ALL { $value.All = true; } )?
		e = expression {
			$value.Expression = new ExpressionItem($e.value);
		} ( COMMA e = expression {
				$value.Expression.Add(
					new ExpressionItem($e.value));
			} )*
	;

havingClause returns [ IExpression value ] :
	HAVING c = searchCondition { $value = $c.value; }
	;

searchCondition returns [ IExpression value ] :
	e = additiveSubSearchCondition { $value = $e.value; }
		( OR r = additiveSubSearchCondition {
			$value = new Expression($value,
				ExpressionOperator.Or,
				$r.value);
		}
		)*
	;

additiveSubSearchCondition returns [ IExpression value ] :
	e = subSearchCondition { $value = $e.value; }
		( AND r = subSearchCondition {
			$value = new Expression($value,
				ExpressionOperator.And,
				$r.value);
		}
		)*
	;

bracketedSearchCondition returns [ IExpression value ] :
	LPAREN e = searchCondition RPAREN {
		$value = $e.value;
	}
	;

subSearchCondition returns [ IExpression value ]
@init { bool negated = false; } :
	( NOT { negated = true; } )? (
		(bracketedSearchCondition) =>
			e = bracketedSearchCondition {
				if (!negated)
				{
					$value = $e.value;
				}
				else
				{
					Expression output = new Expression();
					output.Operator =
						ExpressionOperator.Not;
					output.Right = $e.value;
					$value = output;
				}
		}
		| p = predicate {
			if (!negated)
			{
				$value = $p.value;
			}
			else
			{
				Expression output = new Expression();
				output.Operator = ExpressionOperator.Not;
				output.Right = $p.value;
				$value = output;
			}
		}
		)
	;

predicate returns [ IExpression value ]
@init {
	bool negated = false; 
	ExpressionItem inSet = null;
} :
	l = expression (
        	o = comparisonOperator (
            		r = expression {
				$value = new Expression($l.value,
					$o.value, $r.value);
			}
			| q = quantifierSpec
				LPAREN s = selectStatement RPAREN {
					BracketedExpression expr =
						new BracketedExpression(
							$s.value);
					expr.Spaced = true;
					$value = new PredicateExpression(
						$l.value, $o.value,
						$q.value, expr);
				}
          	)
		| IS {
			$value = new Expression();
			((Expression)$value).Left = $l.value;
			((Expression)$value).Operator =
				ExpressionOperator.IsNull;
		} 
			( NOT {
				((Expression)$value).Operator =
					ExpressionOperator.IsNotNull;
			}
			)? NULL
		| ( NOT { negated = true; } )? (
			LIKE e = expression {
				$value = new PatternExpression(
					$e.value);
			}
				// only single char
				( ESCAPE f = expression {
					((PatternExpression)$value).Escape =
						$f.value;
				}
				)? {
					if (!negated)
					{
						$value = new Expression($l.value, ExpressionOperator.Like, $value);
					}
					else
					{
						$value = new Expression($l.value, ExpressionOperator.NotLike, $value);
					}
				}
			| BETWEEN e = expression AND f = expression {
				Expression inner = new Expression($l.value,
					ExpressionOperator.Between,
					new Range($e.value, $f.value));
				if (!negated)
				{
					$value = inner;
				}
				else
				{
					$value = new Expression();
					((Expression)$value).Operator =
						ExpressionOperator.Not;
					((Expression)$value).Right = inner;
				}
			}
			| IN LPAREN (
				( selectStatement ) =>
					s = selectStatement {
						$value = new Expression($l.value, negated ? ExpressionOperator.NotIn : ExpressionOperator.In, $s.value);
					}
				| e = expression {
					inSet = new ExpressionItem($e.value);
				}
					( COMMA e = expression {
						inSet.Add(new ExpressionItem(
							$e.value));
					} )*
				) RPAREN {
					if ($value == null)
					{
						$value = new Expression($l.value, negated ? ExpressionOperator.NotIn : ExpressionOperator.In, inSet);
					}
				}
 		)
	)
	| EXISTS LPAREN s = selectStatement RPAREN {
		$value = new Expression();
		((Expression)$value).Operator = ExpressionOperator.Exists;
		((Expression)$value).Right = $s.value;
	}
	;

quantifierSpec returns [ PredicateQuantifier value ] :
	ALL { $value = PredicateQuantifier.All; }
	| SOME { $value = PredicateQuantifier.Any; }
	| ANY { $value = PredicateQuantifier.Any; }
	;

selectList returns [ AliasedItem value ] :
	s = selectItem { $value = $s.value; }
		( COMMA t = selectItem { $value.Add($t.value); } )*
	;

selectItem returns [ AliasedItem value ] :
	STAR {
		$value = new AliasedItem(Wildcard.Value);
	} // "*, *" is a valid select list
	| (
		// starts with: "alias = column_name"
		(alias2) => (
			a = alias2 e = expression {
				$value = new AliasedItem($e.value);
				$value.Alias = $a.value;
			}
		)

		// all table columns: "table.*"
		| (tableColumns) => t = tableColumns {
			$value = new AliasedItem($t.value);
		}

		| e = expression {
			$value = new AliasedItem($e.value);
		}
			( a = alias1 { $value.Alias = $a.value; } )?
	)
	;

fromClause returns [ AliasedItem value ] :
	FROM t = tableSource { $value = new AliasedItem($t.value); }
	( COMMA t = tableSource {
		$value.Add(new AliasedItem($t.value));
	} )*
	;

tableSource returns [ Table value ] :
	t = subTableSource { $value = $t.value; }
	( t = joinedTable { $value.Add($t.value); } )*
	;

subTableSource returns [ Table value ] :
	LPAREN (
		(joinedTables) =>
			t = joinedTables RPAREN {
				$value = new Table(
					new BracketedExpression($t.value));
			}
		// "derived table", mandatory alias
		| q = queryExpression RPAREN a = alias1 {
			BracketedExpression expr =
				new BracketedExpression($q.value);
			expr.Spaced = true;
			$value = new Table(expr);
			$value.Alias = $a.value;
		}
        )
	// supporting rowset functions is probably overkill, but
	// user-defined table-valued functions may not be beyond
	// the bounds of possibility...
	| (function) =>
		f = function {
			$value = new Table($f.value);
		}
			( a = alias1 { $value.Alias = $a.value; } )?
	| o = dbObject { $value = new Table($o.value); }
		( a = alias1 { $value.Alias = $a.value; } )?
	;

joinOn returns [ Join value ] :
	( INNER
	| ( LEFT { $value = Join.Left; }
		| RIGHT { $value = Join.Right; }
		| FULL { $value = Join.Full; } )
		( OUTER )? 
	)? JOIN
	;

joinedTable returns [ Table value ] :
	CROSS JOIN t = subTableSource {
		$value = $t.value;
		$value.JoinType = Join.Cross;
	}
	| (
		j = joinOn
			t = tableSource {
				$value = $t.value;
				$value.JoinType = ($j.value == null) ?
					Join.Inner :
					$j.value;
			}
			ON c = searchCondition {
				$value.JoinCondition = $c.value;
			}
		)
	;

joinedTables returns [ Table value ] :
	t = subTableSource { $value = $t.value; }
		( t = joinedTable { $value.Add($t.value); } )+
	;

// edge cases (single-quoted literal but not for table names &
// keywords as identifiers) not supported
alias1 returns [ Identifier value ] :
	(AS)? i = identifier { $value = $i.value; }
	;

alias2 returns [ Identifier value ] :
	i = identifier  { $value = $i.value; }
	ASSIGNEQUAL
	;

tableColumns returns [ TableWildcard value ] :
	o = dbObject DOT_STAR { $value = new TableWildcard($o.value); }
	;

// "++column_name" not supported
column returns [ DbObject value ] :
	o = dbObject { $value = $o.value; }
	// for expression like "(column)" SQL Server returns updatable column
	| LPAREN o = column RPAREN { $value = $o.value; }
	;

expression returns [ IExpression value ] :
	e = additiveSubExpression { $value = $e.value; }
	( o = additiveOperator r = additiveSubExpression {
		$value = new Expression($value, $o.value,
			$r.value);
	} )*
 	;

additiveSubExpression returns [ IExpression value ] :
	e = subExpression { $value = $e.value; }
	( o = multiplicativeArithmeticOperator r = subExpression {
		$value = new Expression($value, $o.value,
			$r.value);
	} )*
	;

bracketedTerm returns [ IExpression value ] :
	LPAREN ( (selectStatement) => 
			s = selectStatement RPAREN {
				$value = new BracketedExpression($s.value);
				((BracketedExpression)$value).Spaced = true;
			}
		| e = expression RPAREN {
			$value = $e.value;
		} )
	;

subExpression returns [ IExpression value ] :
	( o = unaryOperator {
		$value = new Expression();
		((Expression)$value).Operator = $o.value;
	} )? (
		c = constant {
			if ($value == null)
			{
				$value = new Expression();
			}

			((Expression)$value).Right = $c.value;
		}
		| v = variableReference {
			if ($value == null)
			{
				$value = new Expression();
			}

			((Expression)$value).Right = $v.value;
		}
		| PLACEHOLDER {
			if ($value == null)
			{
				$value = new Expression();
			}

			((Expression)$value).Right = Placeholder.Value;
		}
		| (function) =>
			f = function {
				if ($value == null)
				{
					// Oracle tailor wanting to replace
					// a datetime function will
					// appreciate an Expression parent
					$value = new Expression();
				}

				((Expression)$value).Right = $f.value;
			}
		| e = bracketedTerm {
			if ($value == null)
			{
				$value = $e.value;
			}
			else
			{
				((Expression)$value).Right = $e.value;
			}
		}
		| d = dbObject {
			if ($value == null)
			{
				$value = new Expression();
			}

			((Expression)$value).Right = $d.value;
		}
                // parameterless functions not supported - there
                // don't seem to be any portable ones...
		| p = caseFunction {
				if ($value == null)
				{
					// tailors wanting to replace this
					// object will appreciate
					// an Expression parent
					$value = new Expression();
				}

				((Expression)$value).Right = $p.value;
			}
		| q = castFunction{
				if ($value == null)
				{
					$value = $q.value;
				}
				else
				{
					((Expression)$value).Right = $q.value;
				}
			}
	)
	;

variableReference returns [ Variable value ] :
	Variable { $value = new Variable($Variable.text); }
	;

// todo: create a separate rule for aggregate functions
function returns [ IExpression value ] :
	SUBSTRING {
		$value = new FunctionCall(TailorUtil.SUBSTRING);
	} LPAREN v = expression {
 			((FunctionCall)$value).ExpressionArguments =
				new ExpressionItem($v.value);
		} FROM s = expression {
			((FunctionCall)$value).ExpressionArguments.Add(
				new ExpressionItem($s.value));
		} ( FOR l = expression {
				((FunctionCall)$value).ExpressionArguments.Add(new ExpressionItem($l.value));
			} )? RPAREN
	| EXTRACT LPAREN d = datetimeField FROM s = expression {
			$value = new ExtractFunction($d.value, $s.value);
		} RPAREN
	| f = genericFunction {
		$value = $f.value;
	}
	;

genericFunction returns [ FunctionCall value ] :
	// LEFT and RIGHT keywords are also function names
	(
		// MS SQL Server 2005 doesn't accept quoted identifiers
		// (e.g. [count]) as function names
		NonQuotedIdentifier {
			$value = new FunctionCall($NonQuotedIdentifier.text);
		}
		| LEFT {
			$value = new FunctionCall(
				TailorUtil.LEFT.ToUpperInvariant());
		}
		| RIGHT {
			$value = new FunctionCall(
				TailorUtil.RIGHT.ToUpperInvariant());
		}
	) LPAREN (
		e = functionArgument {
 			$value.ExpressionArguments =
				new ExpressionItem($e.value);
		}
			( COMMA e = functionArgument {
				$value.ExpressionArguments.Add(
					new ExpressionItem($e.value));
			} )*
		// aggregate functions like Count(), Checksum()
		// accept "*" as a parameter
		| STAR { $value.Star = Wildcard.Value; }
        	| (ALL | DISTINCT { $value.Distinct = true; } ) (
			STAR { $value.Star = Wildcard.Value;
			}
			// aggregate function
			| e = expression {
	 			$value.ExpressionArguments =
					new ExpressionItem($e.value);
			}
		)
		// named arguments not supported
        )? RPAREN
	;

functionArgument returns [ IExpression value ] :
	e = expression {
		$value = $e.value;
	}
	| d = datetimeField {
		$value = new Expression();
		((Expression)$value).Left = $d.value;
	}
	;

caseFunction returns [ CaseExpression value ] :
	CASE { $value = new CaseExpression(); } (
		e = expression { $value.Case = $e.value; }
			( WHEN e = expression THEN f = expression {
				$value.Add(new CaseAlternative($e.value,
					$f.value));
			} )+
	// boolean expressions
        | ( WHEN e = searchCondition THEN f = expression {
			$value.Add(new CaseAlternative($e.value,
				$f.value));
		} )+
        )
		( ELSE e = expression {
			$value.Else = $e.value;
		} )? END ( CASE )? // Oracle acepts both terminators
	;

castFunction returns [ TypeCast value ] :
	CAST LPAREN e = expression AS t = typeIdentifier {
		$value = new TypeCast($e.value, $t.value);
	}
		( LPAREN p = nonNegativeInteger {
			$value.Precision = $p.value;
		} ( COMMA p = nonNegativeInteger {
				$value.SecondPrecision = $p.value;
			} )? RPAREN )? RPAREN
	;

dbObject returns [ DbObject value ] :
	i = identifier { $value = new DbObject($i.value); }
	( DOT i = identifier { $value.Add(new DbObject($i.value)); } ) *
	;

// SQL 92 allows string literals broken by whitespace/comments
// (as long as it contains a newline - we're more permissive than that,
// and also allow mixing ASCII parts into Unicode strings).
stringLiteral returns [ StringValue value ] :
	s = singleStringLiteral {
		$value = $s.value;
	} ( s = singleStringLiteral {
		$value.Append($s.value);
		} )*
	;

singleStringLiteral returns [ StringValue value ] :
	UnicodeStringLiteral {
		$value = new StringValue($UnicodeStringLiteral.text);
		$value.QuoteType = 'n';
	}
	| AsciiStringLiteral {
		$value = new StringValue($AsciiStringLiteral.text);
	}
	;

identifier returns [ Identifier value ] :
	NonQuotedIdentifier {
		$value = new Identifier($NonQuotedIdentifier.text);
	}
	| QuotedIdentifier {
		$value = new Identifier($QuotedIdentifier.text);
	}
	;

typeIdentifier returns [ string value ] :
	NonQuotedIdentifier { $value = $NonQuotedIdentifier.text; }
	;

constant returns [ INode value ] :
	i = nonNegativeInteger { $value = new IntegerValue($i.value); }
	| Real { $value = new DoubleValue(DoubleValue.Parse($Real.text)); }
	| NULL { $value = NullValue.Value; }
	| s = stringLiteral { $value = $s.value; }
	| j = intervalLiteral { $value = $j.value; }
	| HexLiteral {
		$value = new IntegerValue(
			IntegerValue.ParseHex($HexLiteral.text));
	}
	// subset of an MS Access-specific format
	| MAccessDateTime {
		$value = new LiteralDateTime($MAccessDateTime.text);
	}
	// subset of ISO 8601 recommended for SQL Server 2005
	| Iso8601DateTime {
		$value = new LiteralDateTime($Iso8601DateTime.text);
	}
	| TIMESTAMP s = stringLiteral {
		$value = new LiteralDateTime($s.value);
	}
	// currency & system variables not supported
	;

intervalLiteral returns [ Interval value ]
@init { bool positive = true; int intervalNumber = 0; } :
	INTERVAL ( u = unaryOperator { 
			positive = ($u.value == ExpressionOperator.Plus);
		} )? AsciiStringLiteral {
			intervalNumber = Interval.Parse(
				$AsciiStringLiteral.text);
		} d = datetimeField {
			$value = new Interval(positive, intervalNumber,
				$d.value);
		} ( LPAREN Integer {
			$value.Precision = int.Parse($Integer.text);
		} RPAREN )?
	;

nonNegativeInteger returns [ int value ] :
	Integer { $value = int.Parse($Integer.text); }
	;

unaryOperator returns [ ExpressionOperator value ] :
	PLUS { $value = ExpressionOperator.Plus; }
	| MINUS { $value = ExpressionOperator.Minus; }
	;

additiveOperator returns [ ExpressionOperator value ] :
	PLUS { $value = ExpressionOperator.Plus; }
	| MINUS { $value = ExpressionOperator.Minus; }
	| STRCONCAT { $value = ExpressionOperator.StrConcat; }
	;
    
multiplicativeArithmeticOperator returns [ ExpressionOperator value ] :
	STAR { $value = ExpressionOperator.Mult; }
	| DIVIDE { $value = ExpressionOperator.Div; }
	| MOD { $value = ExpressionOperator.Mod; }
	;
    
comparisonOperator returns [ ExpressionOperator value ] :
	ASSIGNEQUAL { $value = ExpressionOperator.Equal; }
	| NOTEQUAL1 { $value = ExpressionOperator.NotEqual; }
	| NOTEQUAL2 { $value = ExpressionOperator.NotEqual; }
	| LESSTHANOREQUALTO1 { $value = ExpressionOperator.LessOrEqual; }
	| LESSTHAN { $value = ExpressionOperator.Less; }
	| GREATERTHANOREQUALTO1 { $value = ExpressionOperator.GreaterOrEqual; }
	| GREATERTHAN { $value = ExpressionOperator.Greater; }
	;

unionOperator returns [ bool value ] :
	UNION { $value = false; }
	( ALL { $value = true; } )?
	;

datetimeField returns [ DateTimeUnit value ] :
	YEAR { $value = DateTimeUnit.Year; }
	| MONTH { $value = DateTimeUnit.Month; }
	| DAY { $value = DateTimeUnit.Day; }
	| HOUR { $value = DateTimeUnit.Hour; }
	| MINUTE { $value = DateTimeUnit.Minute; }
	| SECOND { $value = DateTimeUnit.Second; }
	;

ALL : 'all' ;
AND : 'and' ;
ANY : 'any' ;
AS : 'as' ;
ASC : 'asc' ;
BETWEEN : 'between' ;
BY : 'by' ;
CASE : 'case' ;
CAST : 'cast' ;
CROSS : 'cross' ;
DAY : 'day' ;
DEFAULT : 'default' ;
DELETE : 'delete' ;
DESC : 'desc' ;
DISTINCT : 'distinct' ;
ELSE : 'else' ;
END : 'end' ;
ESCAPE : 'escape' ;
EXISTS : 'exists' ;
EXTRACT : 'extract' ;
FOR : 'for' ;
FROM : 'from' ;
FULL : 'full' ;
GROUP : 'group' ;
HAVING : 'having' ;
HOUR : 'hour' ;
IN : 'in' ;
INNER : 'inner' ;
INSERT : 'insert' ;
INTERVAL : 'interval' ;
INTO : 'into' ;
IS : 'is' ;
JOIN : 'join' ;
LEFT : 'left' ;
LIKE : 'like' ;
MINUTE : 'minute' ;
MONTH : 'month' ;
NOT : 'not' ;
NULL : 'null' ;
ON : 'on' ;
OR : 'or' ;
ORDER : 'order' ;
OUTER : 'outer' ;
RIGHT : 'right' ;
SECOND : 'second' ;
SELECT : 'select' ;
SET : 'set' ;
SOME : 'some' ;
SUBSTRING : 'substring' ;
THEN : 'then' ;
TIMESTAMP: 'timestamp';
TOP : 'top' ;
UNION : 'union' ;
UPDATE : 'update' ;
VALUES : 'values' ;
WHEN : 'when' ;
WHERE : 'where' ;
YEAR : 'year' ;

DOT_STAR: '.*' ;
DOT : '.' ;
COMMA : ',' ;
LPAREN : '(' ;
RPAREN : ')' ;

ASSIGNEQUAL : '=' ;
NOTEQUAL1 : '<>' ;
NOTEQUAL2 : '!=' ;
LESSTHANOREQUALTO1 : '<=' ;
LESSTHAN : '<' ;
GREATERTHANOREQUALTO1 : '>=' ;
GREATERTHAN : '>' ;

DIVIDE : '/' ;
PLUS : '+' ;
STAR : '*' ;
MOD : '%' ;

STRCONCAT : '||' ;

PLACEHOLDER: '?' ;

fragment
Letter : 'a'..'z' ;

fragment
Digit : '0'..'9' ;

fragment
Integer :;

fragment
Real :;

fragment
Exponent :
	'e' ( '+' | '-' )? (Digit)+
	;

MAccessDateTime :
	'#' Digit Digit Digit Digit '-'
		Digit Digit '-' Digit Digit ' '
		Digit Digit ':' Digit Digit ':' Digit Digit
		'#'
	;

Iso8601DateTime :
	Digit Digit Digit Digit '-'
		Digit Digit '-' Digit Digit ( 't' | ' ' )
		Digit Digit ':' Digit Digit ':' Digit Digit
	;

Number :
	( (Digit)+ ('.' | 'e') ) => (Digit)+ ( '.' (Digit)* (Exponent)? | Exponent) { $type = Real; }
	| '.' { $type = DOT; } ( (Digit)+ (Exponent)? { $type = Real; } )?
	| (Digit)+ { $type = Integer; }
	| '0x' ('a'..'f' | Digit)* { $type = HexLiteral; } // "0x" is valid hex literal
	;

fragment
WordTail :
	(Letter | Digit | '_' )*
	;

NonQuotedIdentifier : Letter WordTail ;

QuotedIdentifier :
	'[' (~']')* ']' (']' (~']')* ']')*
	| '"' (~'"')* '"' ('"' (~'"')* '"')* // SQL 92 <delimited identifier>
	| '`' (~'`')* '`'	// MS Access; not sure whether the identifier
				// can contain doubled backquotes (and
				// doubtful that it would be desirable
				// in the first place), so playing it
				// safe & not allowing them
    ;

// Note that after the first char, it's the same as in
// NonQuotedIdentifier - some application code relies on that, i.e. when
// generating parameter names.
Variable :
	( '@' | ':' ) Letter WordTail
	;

fragment
AsciiStringRun :
	// single-line literals only
	( '\t' | ' ' .. '&' | '(' .. '~' )+
	;

AsciiStringLiteral :
	'\'' { $text = ""; }
	( s = AsciiStringRun { $text = $s.text; } )? '\''
	( '\'' {
			$text = $text + "\'";
		} ( s = AsciiStringRun { $text = $text + $s.text; } )? '\''
	)*
	;

fragment
UnicodeStringRun :
	(~ '\'' )+
	;

UnicodeStringLiteral :
	'n' '\'' { $text = ""; }
	( s = UnicodeStringRun { $text = $s.text; } )? '\''
	( '\'' {
			$text = $text + "\'";
		} ( s = UnicodeStringRun { $text = $text + $s.text; } )? '\''
	)*
	;

fragment
HexLiteral : // generated as a part of Number rule
	// '0x' ('0'..'9' | 'a'..'f')*
	;

MINUS : '-' ;
COLON : ':' ;

Whitespace : ( '\t' | ' ' | '\r' | '\n' )+ 	{ $channel = HIDDEN; }
	;
