// $ANTLR 3.1.2 MacroScope\\MacroScope.g 2009-03-25 09:39:27

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
namespace 
	MacroScope

{

using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

public partial class MacroScopeParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"INSERT", 
		"INTO", 
		"LPAREN", 
		"RPAREN", 
		"VALUES", 
		"UPDATE", 
		"SET", 
		"DELETE", 
		"FROM", 
		"COMMA", 
		"ASSIGNEQUAL", 
		"DEFAULT", 
		"SELECT", 
		"ALL", 
		"DISTINCT", 
		"TOP", 
		"Integer", 
		"WHERE", 
		"ORDER", 
		"BY", 
		"ASC", 
		"DESC", 
		"GROUP", 
		"HAVING", 
		"OR", 
		"AND", 
		"NOT", 
		"IS", 
		"NULL", 
		"LIKE", 
		"ESCAPE", 
		"BETWEEN", 
		"IN", 
		"EXISTS", 
		"SOME", 
		"ANY", 
		"STAR", 
		"INNER", 
		"LEFT", 
		"RIGHT", 
		"FULL", 
		"OUTER", 
		"JOIN", 
		"CROSS", 
		"ON", 
		"AS", 
		"DOT_STAR", 
		"PLACEHOLDER", 
		"Variable", 
		"SUBSTRING", 
		"FOR", 
		"EXTRACT", 
		"NonQuotedIdentifier", 
		"CASE", 
		"WHEN", 
		"THEN", 
		"ELSE", 
		"END", 
		"CAST", 
		"DOT", 
		"UnicodeStringLiteral", 
		"AsciiStringLiteral", 
		"QuotedIdentifier", 
		"Real", 
		"HexLiteral", 
		"MAccessDateTime", 
		"Iso8601DateTime", 
		"TIMESTAMP", 
		"INTERVAL", 
		"PLUS", 
		"MINUS", 
		"STRCONCAT", 
		"DIVIDE", 
		"MOD", 
		"NOTEQUAL1", 
		"NOTEQUAL2", 
		"LESSTHANOREQUALTO1", 
		"LESSTHAN", 
		"GREATERTHANOREQUALTO1", 
		"GREATERTHAN", 
		"UNION", 
		"YEAR", 
		"MONTH", 
		"DAY", 
		"HOUR", 
		"MINUTE", 
		"SECOND", 
		"Letter", 
		"Digit", 
		"Exponent", 
		"Number", 
		"WordTail", 
		"AsciiStringRun", 
		"UnicodeStringRun", 
		"COLON", 
		"Whitespace"
    };

    public const int CAST = 62;
    public const int STAR = 40;
    public const int MOD = 77;
    public const int GREATERTHANOREQUALTO1 = 82;
    public const int DOT_STAR = 50;
    public const int CASE = 57;
    public const int DAY = 87;
    public const int NOT = 30;
    public const int ASSIGNEQUAL = 14;
    public const int EOF = -1;
    public const int MONTH = 86;
    public const int RPAREN = 7;
    public const int FULL = 44;
    public const int Variable = 52;
    public const int ESCAPE = 34;
    public const int INSERT = 4;
    public const int NonQuotedIdentifier = 56;
    public const int SELECT = 16;
    public const int INTO = 5;
    public const int DIVIDE = 76;
    public const int PLACEHOLDER = 51;
    public const int GREATERTHAN = 83;
    public const int SECOND = 90;
    public const int ASC = 24;
    public const int UnicodeStringLiteral = 64;
    public const int NULL = 32;
    public const int ELSE = 60;
    public const int ON = 48;
    public const int DELETE = 11;
    public const int GROUP = 26;
    public const int MAccessDateTime = 69;
    public const int OR = 28;
    public const int LESSTHANOREQUALTO1 = 80;
    public const int FROM = 12;
    public const int END = 61;
    public const int DISTINCT = 18;
    public const int Letter = 91;
    public const int TIMESTAMP = 71;
    public const int WHERE = 21;
    public const int UnicodeStringRun = 97;
    public const int INNER = 41;
    public const int YEAR = 85;
    public const int ORDER = 22;
    public const int UPDATE = 9;
    public const int AsciiStringLiteral = 65;
    public const int Exponent = 93;
    public const int FOR = 54;
    public const int AND = 29;
    public const int CROSS = 47;
    public const int INTERVAL = 72;
    public const int LPAREN = 6;
    public const int AS = 49;
    public const int IN = 36;
    public const int THEN = 59;
    public const int Number = 94;
    public const int COMMA = 13;
    public const int IS = 31;
    public const int LEFT = 42;
    public const int SOME = 38;
    public const int ALL = 17;
    public const int Real = 67;
    public const int PLUS = 73;
    public const int EXISTS = 37;
    public const int EXTRACT = 55;
    public const int DOT = 63;
    public const int Whitespace = 99;
    public const int LIKE = 33;
    public const int OUTER = 45;
    public const int HexLiteral = 68;
    public const int BY = 23;
    public const int LESSTHAN = 81;
    public const int AsciiStringRun = 96;
    public const int DEFAULT = 15;
    public const int VALUES = 8;
    public const int RIGHT = 43;
    public const int SET = 10;
    public const int HAVING = 27;
    public const int MINUS = 74;
    public const int Digit = 92;
    public const int HOUR = 88;
    public const int QuotedIdentifier = 66;
    public const int WordTail = 95;
    public const int JOIN = 46;
    public const int UNION = 84;
    public const int SUBSTRING = 53;
    public const int COLON = 98;
    public const int STRCONCAT = 75;
    public const int ANY = 39;
    public const int WHEN = 58;
    public const int NOTEQUAL1 = 78;
    public const int NOTEQUAL2 = 79;
    public const int DESC = 25;
    public const int MINUTE = 89;
    public const int TOP = 19;
    public const int BETWEEN = 35;
    public const int Integer = 20;
    public const int Iso8601DateTime = 70;

    // delegates
    // delegators



        public MacroScopeParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public MacroScopeParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return MacroScopeParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "MacroScope\\MacroScope.g"; }
    }



    // $ANTLR start "statement"
    // MacroScope\\MacroScope.g:27:1: statement returns [ IStatement value ] : (i= insertStatement EOF | s= selectStatement EOF | u= updateStatement EOF | d= deleteStatement EOF );
    public IStatement statement() // throws RecognitionException [1]
    {   
        IStatement value = default(IStatement);

        InsertStatement i = default(InsertStatement);

        SelectStatement s = default(SelectStatement);

        UpdateStatement u = default(UpdateStatement);

        DeleteStatement d = default(DeleteStatement);


        try 
    	{
            // MacroScope\\MacroScope.g:27:40: (i= insertStatement EOF | s= selectStatement EOF | u= updateStatement EOF | d= deleteStatement EOF )
            int alt1 = 4;
            switch ( input.LA(1) ) 
            {
            case INSERT:
            	{
                alt1 = 1;
                }
                break;
            case LPAREN:
            case SELECT:
            	{
                alt1 = 2;
                }
                break;
            case UPDATE:
            	{
                alt1 = 3;
                }
                break;
            case DELETE:
            	{
                alt1 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:28:2: i= insertStatement EOF
                    {
                    	PushFollow(FOLLOW_insertStatement_in_statement66);
                    	i = insertStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	Match(input,EOF,FOLLOW_EOF_in_statement68); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  i; 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:29:4: s= selectStatement EOF
                    {
                    	PushFollow(FOLLOW_selectStatement_in_statement79);
                    	s = selectStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	Match(input,EOF,FOLLOW_EOF_in_statement81); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  s; 
                    	}

                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:30:4: u= updateStatement EOF
                    {
                    	PushFollow(FOLLOW_updateStatement_in_statement92);
                    	u = updateStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	Match(input,EOF,FOLLOW_EOF_in_statement94); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  u; 
                    	}

                    }
                    break;
                case 4 :
                    // MacroScope\\MacroScope.g:31:4: d= deleteStatement EOF
                    {
                    	PushFollow(FOLLOW_deleteStatement_in_statement105);
                    	d = deleteStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	Match(input,EOF,FOLLOW_EOF_in_statement107); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  d; 
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "statement"


    // $ANTLR start "insertStatement"
    // MacroScope\\MacroScope.g:34:1: insertStatement returns [ InsertStatement value ] : INSERT ( INTO )? o= dbObject LPAREN c= columnNameList RPAREN VALUES LPAREN e= columnValueList RPAREN ;
    public InsertStatement insertStatement() // throws RecognitionException [1]
    {   
        InsertStatement value = default(InsertStatement);

        DbObject o = default(DbObject);

        AliasedItem c = default(AliasedItem);

        ExpressionItem e = default(ExpressionItem);


        try 
    	{
            // MacroScope\\MacroScope.g:34:51: ( INSERT ( INTO )? o= dbObject LPAREN c= columnNameList RPAREN VALUES LPAREN e= columnValueList RPAREN )
            // MacroScope\\MacroScope.g:36:2: INSERT ( INTO )? o= dbObject LPAREN c= columnNameList RPAREN VALUES LPAREN e= columnValueList RPAREN
            {
            	Match(input,INSERT,FOLLOW_INSERT_in_insertStatement126); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new InsertStatement(); 
            	}
            	// MacroScope\\MacroScope.g:36:45: ( INTO )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == INTO) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:36:47: INTO
            	        {
            	        	Match(input,INTO,FOLLOW_INTO_in_insertStatement132); if (state.failed) return value;

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_dbObject_in_insertStatement143);
            	o = dbObject();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  			value.Table = o;
            	  		
            	}
            	Match(input,LPAREN,FOLLOW_LPAREN_in_insertStatement155); if (state.failed) return value;
            	PushFollow(FOLLOW_columnNameList_in_insertStatement161);
            	c = columnNameList();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	Match(input,RPAREN,FOLLOW_RPAREN_in_insertStatement163); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  			value.ColumnNames = c;
            	  		
            	}
            	Match(input,VALUES,FOLLOW_VALUES_in_insertStatement169); if (state.failed) return value;
            	Match(input,LPAREN,FOLLOW_LPAREN_in_insertStatement171); if (state.failed) return value;
            	PushFollow(FOLLOW_columnValueList_in_insertStatement177);
            	e = columnValueList();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	Match(input,RPAREN,FOLLOW_RPAREN_in_insertStatement179); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  			value.ColumnValues = e;
            	  		
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "insertStatement"


    // $ANTLR start "selectStatement"
    // MacroScope\\MacroScope.g:52:1: selectStatement returns [ SelectStatement value ] : q= queryExpression ;
    public SelectStatement selectStatement() // throws RecognitionException [1]
    {   
        SelectStatement value = default(SelectStatement);

        QueryExpression q = default(QueryExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:52:51: (q= queryExpression )
            // MacroScope\\MacroScope.g:53:2: q= queryExpression
            {
            	PushFollow(FOLLOW_queryExpression_in_selectStatement206);
            	q = queryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new SelectStatement(q); 
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "selectStatement"


    // $ANTLR start "updateStatement"
    // MacroScope\\MacroScope.g:56:1: updateStatement returns [ UpdateStatement value ] : UPDATE o= dbObject SET a= assignmentList (w= whereClause )? ;
    public UpdateStatement updateStatement() // throws RecognitionException [1]
    {   
        UpdateStatement value = default(UpdateStatement);

        DbObject o = default(DbObject);

        Assignment a = default(Assignment);

        IExpression w = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:56:51: ( UPDATE o= dbObject SET a= assignmentList (w= whereClause )? )
            // MacroScope\\MacroScope.g:58:2: UPDATE o= dbObject SET a= assignmentList (w= whereClause )?
            {
            	Match(input,UPDATE,FOLLOW_UPDATE_in_updateStatement225); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new UpdateStatement(); 
            	}
            	PushFollow(FOLLOW_dbObject_in_updateStatement235);
            	o = dbObject();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value.Table = o; 
            	}
            	Match(input,SET,FOLLOW_SET_in_updateStatement241); if (state.failed) return value;
            	PushFollow(FOLLOW_assignmentList_in_updateStatement247);
            	a = assignmentList();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  			value.Assignments = a;
            	  		
            	}
            	// MacroScope\\MacroScope.g:64:3: (w= whereClause )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == WHERE) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:65:4: w= whereClause
            	        {
            	        	PushFollow(FOLLOW_whereClause_in_updateStatement266);
            	        	w = whereClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.Where = w; 
            	        	}

            	        }
            	        break;

            	}


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "updateStatement"


    // $ANTLR start "deleteStatement"
    // MacroScope\\MacroScope.g:70:1: deleteStatement returns [ DeleteStatement value ] : DELETE ( FROM )? o= dbObject (w= whereClause )? ;
    public DeleteStatement deleteStatement() // throws RecognitionException [1]
    {   
        DeleteStatement value = default(DeleteStatement);

        DbObject o = default(DbObject);

        IExpression w = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:70:51: ( DELETE ( FROM )? o= dbObject (w= whereClause )? )
            // MacroScope\\MacroScope.g:72:2: DELETE ( FROM )? o= dbObject (w= whereClause )?
            {
            	Match(input,DELETE,FOLLOW_DELETE_in_deleteStatement293); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new DeleteStatement(); 
            	}
            	// MacroScope\\MacroScope.g:72:45: ( FROM )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == FROM) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:72:47: FROM
            	        {
            	        	Match(input,FROM,FOLLOW_FROM_in_deleteStatement299); if (state.failed) return value;

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_dbObject_in_deleteStatement310);
            	o = dbObject();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value.Table = o; 
            	}
            	// MacroScope\\MacroScope.g:74:3: (w= whereClause )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == WHERE) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:75:4: w= whereClause
            	        {
            	        	PushFollow(FOLLOW_whereClause_in_deleteStatement326);
            	        	w = whereClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.Where = w; 
            	        	}

            	        }
            	        break;

            	}


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "deleteStatement"


    // $ANTLR start "assignmentList"
    // MacroScope\\MacroScope.g:80:1: assignmentList returns [ Assignment value ] : a= assignment ( COMMA a= assignment )* ;
    public Assignment assignmentList() // throws RecognitionException [1]
    {   
        Assignment value = default(Assignment);

        Assignment a = default(Assignment);


        try 
    	{
            // MacroScope\\MacroScope.g:80:45: (a= assignment ( COMMA a= assignment )* )
            // MacroScope\\MacroScope.g:81:2: a= assignment ( COMMA a= assignment )*
            {
            	PushFollow(FOLLOW_assignment_in_assignmentList356);
            	a = assignment();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  		value =  a;
            	  	
            	}
            	// MacroScope\\MacroScope.g:83:4: ( COMMA a= assignment )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == COMMA) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:83:6: COMMA a= assignment
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_assignmentList362); if (state.failed) return value;
            			    	PushFollow(FOLLOW_assignment_in_assignmentList368);
            			    	a = assignment();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  			value.Add(a);
            			    	  		
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "assignmentList"


    // $ANTLR start "assignment"
    // MacroScope\\MacroScope.g:88:1: assignment returns [ Assignment value ] : c= column ASSIGNEQUAL v= columnValue ;
    public Assignment assignment() // throws RecognitionException [1]
    {   
        Assignment value = default(Assignment);

        DbObject c = default(DbObject);

        INode v = default(INode);


        try 
    	{
            // MacroScope\\MacroScope.g:88:41: (c= column ASSIGNEQUAL v= columnValue )
            // MacroScope\\MacroScope.g:89:2: c= column ASSIGNEQUAL v= columnValue
            {
            	PushFollow(FOLLOW_column_in_assignment392);
            	c = column();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	Match(input,ASSIGNEQUAL,FOLLOW_ASSIGNEQUAL_in_assignment394); if (state.failed) return value;
            	PushFollow(FOLLOW_columnValue_in_assignment400);
            	v = columnValue();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  		value =  new Assignment(c, v);
            	  	
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "assignment"


    // $ANTLR start "columnNameList"
    // MacroScope\\MacroScope.g:94:1: columnNameList returns [ AliasedItem value ] : c= column ( COMMA c= column )* ;
    public AliasedItem columnNameList() // throws RecognitionException [1]
    {   
        AliasedItem value = default(AliasedItem);

        DbObject c = default(DbObject);


        try 
    	{
            // MacroScope\\MacroScope.g:94:46: (c= column ( COMMA c= column )* )
            // MacroScope\\MacroScope.g:95:2: c= column ( COMMA c= column )*
            {
            	PushFollow(FOLLOW_column_in_columnNameList421);
            	c = column();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new AliasedItem(c); 
            	}
            	// MacroScope\\MacroScope.g:96:3: ( COMMA c= column )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == COMMA) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:96:5: COMMA c= column
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_columnNameList429); if (state.failed) return value;
            			    	PushFollow(FOLLOW_column_in_columnNameList435);
            			    	c = column();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  			value.Add(new AliasedItem(c));
            			    	  		
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "columnNameList"


    // $ANTLR start "columnValueList"
    // MacroScope\\MacroScope.g:101:1: columnValueList returns [ ExpressionItem value ] : v= columnValue ( COMMA v= columnValue )* ;
    public ExpressionItem columnValueList() // throws RecognitionException [1]
    {   
        ExpressionItem value = default(ExpressionItem);

        INode v = default(INode);


        try 
    	{
            // MacroScope\\MacroScope.g:101:50: (v= columnValue ( COMMA v= columnValue )* )
            // MacroScope\\MacroScope.g:102:2: v= columnValue ( COMMA v= columnValue )*
            {
            	PushFollow(FOLLOW_columnValue_in_columnValueList459);
            	v = columnValue();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  		value =  new ExpressionItem(v);
            	  	
            	}
            	// MacroScope\\MacroScope.g:104:4: ( COMMA v= columnValue )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == COMMA) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:104:6: COMMA v= columnValue
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_columnValueList465); if (state.failed) return value;
            			    	PushFollow(FOLLOW_columnValue_in_columnValueList471);
            			    	v = columnValue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  			value.Add(new ExpressionItem(v));
            			    	  		
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "columnValueList"


    // $ANTLR start "columnValue"
    // MacroScope\\MacroScope.g:109:1: columnValue returns [ INode value ] : ( DEFAULT | e= expression );
    public INode columnValue() // throws RecognitionException [1]
    {   
        INode value = default(INode);

        IExpression e = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:109:37: ( DEFAULT | e= expression )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == DEFAULT) )
            {
                alt9 = 1;
            }
            else if ( (LA9_0 == LPAREN || LA9_0 == Integer || LA9_0 == NULL || (LA9_0 >= LEFT && LA9_0 <= RIGHT) || (LA9_0 >= PLACEHOLDER && LA9_0 <= SUBSTRING) || (LA9_0 >= EXTRACT && LA9_0 <= CASE) || LA9_0 == CAST || (LA9_0 >= UnicodeStringLiteral && LA9_0 <= MINUS)) )
            {
                alt9 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:110:2: DEFAULT
                    {
                    	Match(input,DEFAULT,FOLLOW_DEFAULT_in_columnValue491); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  DefaultValue.Value; 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:111:4: e= expression
                    {
                    	PushFollow(FOLLOW_expression_in_columnValue502);
                    	e = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  e; 
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "columnValue"


    // $ANTLR start "queryExpression"
    // MacroScope\\MacroScope.g:114:1: queryExpression returns [ QueryExpression value ] : s= subQueryExpression (u= unionOperator s= subQueryExpression )* (o= orderByClause )? ;
    public QueryExpression queryExpression() // throws RecognitionException [1]
    {   
        QueryExpression value = default(QueryExpression);

        QueryExpression s = default(QueryExpression);

        bool u = default(bool);

        OrderExpression o = default(OrderExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:114:51: (s= subQueryExpression (u= unionOperator s= subQueryExpression )* (o= orderByClause )? )
            // MacroScope\\MacroScope.g:115:2: s= subQueryExpression (u= unionOperator s= subQueryExpression )* (o= orderByClause )?
            {
            	PushFollow(FOLLOW_subQueryExpression_in_queryExpression523);
            	s = subQueryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  s; 
            	}
            	// MacroScope\\MacroScope.g:116:2: (u= unionOperator s= subQueryExpression )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == UNION) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:116:4: u= unionOperator s= subQueryExpression
            			    {
            			    	PushFollow(FOLLOW_unionOperator_in_queryExpression535);
            			    	u = unionOperator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	PushFollow(FOLLOW_subQueryExpression_in_queryExpression543);
            			    	s = subQueryExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  			s.All = u;
            			    	  			value.Add(s);
            			    	  		
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	// MacroScope\\MacroScope.g:122:2: (o= orderByClause )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == ORDER) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:122:4: o= orderByClause
            	        {
            	        	PushFollow(FOLLOW_orderByClause_in_queryExpression558);
            	        	o = orderByClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.SetOrderBy(o); 
            	        	}

            	        }
            	        break;

            	}


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "queryExpression"


    // $ANTLR start "subQueryExpression"
    // MacroScope\\MacroScope.g:125:1: subQueryExpression returns [ QueryExpression value ] : (s= querySpecification | LPAREN s= queryExpression RPAREN );
    public QueryExpression subQueryExpression() // throws RecognitionException [1]
    {   
        QueryExpression value = default(QueryExpression);

        QueryExpression s = default(QueryExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:125:54: (s= querySpecification | LPAREN s= queryExpression RPAREN )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == SELECT) )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == LPAREN) )
            {
                alt12 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:126:2: s= querySpecification
                    {
                    	PushFollow(FOLLOW_querySpecification_in_subQueryExpression582);
                    	s = querySpecification();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  s; 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:127:4: LPAREN s= queryExpression RPAREN
                    {
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_subQueryExpression590); if (state.failed) return value;
                    	PushFollow(FOLLOW_queryExpression_in_subQueryExpression596);
                    	s = queryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	Match(input,RPAREN,FOLLOW_RPAREN_in_subQueryExpression598); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  s; 
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "subQueryExpression"


    // $ANTLR start "querySpecification"
    // MacroScope\\MacroScope.g:130:1: querySpecification returns [ QueryExpression value ] : s= selectClause (f= fromClause )? (w= whereClause )? (g= groupByClause (h= havingClause )? )? ;
    public QueryExpression querySpecification() // throws RecognitionException [1]
    {   
        QueryExpression value = default(QueryExpression);

        QueryExpression s = default(QueryExpression);

        AliasedItem f = default(AliasedItem);

        IExpression w = default(IExpression);

        GroupByClause g = default(GroupByClause);

        IExpression h = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:130:54: (s= selectClause (f= fromClause )? (w= whereClause )? (g= groupByClause (h= havingClause )? )? )
            // MacroScope\\MacroScope.g:131:2: s= selectClause (f= fromClause )? (w= whereClause )? (g= groupByClause (h= havingClause )? )?
            {
            	PushFollow(FOLLOW_selectClause_in_querySpecification619);
            	s = selectClause();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  s; 
            	}
            	// MacroScope\\MacroScope.g:132:2: (f= fromClause )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == FROM) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:132:4: f= fromClause
            	        {
            	        	PushFollow(FOLLOW_fromClause_in_querySpecification630);
            	        	f = fromClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.From = f; 
            	        	}

            	        }
            	        break;

            	}

            	// MacroScope\\MacroScope.g:133:2: (w= whereClause )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == WHERE) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:133:4: w= whereClause
            	        {
            	        	PushFollow(FOLLOW_whereClause_in_querySpecification644);
            	        	w = whereClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.Where = w; 
            	        	}

            	        }
            	        break;

            	}

            	// MacroScope\\MacroScope.g:134:2: (g= groupByClause (h= havingClause )? )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == GROUP) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:134:4: g= groupByClause (h= havingClause )?
            	        {
            	        	PushFollow(FOLLOW_groupByClause_in_querySpecification658);
            	        	g = groupByClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.GroupBy = g; 
            	        	}
            	        	// MacroScope\\MacroScope.g:135:3: (h= havingClause )?
            	        	int alt15 = 2;
            	        	int LA15_0 = input.LA(1);

            	        	if ( (LA15_0 == HAVING) )
            	        	{
            	        	    alt15 = 1;
            	        	}
            	        	switch (alt15) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:135:5: h= havingClause
            	        	        {
            	        	        	PushFollow(FOLLOW_havingClause_in_querySpecification670);
            	        	        	h = havingClause();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return value;
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   value.GroupBy.Having = h; 
            	        	        	}

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "querySpecification"


    // $ANTLR start "selectClause"
    // MacroScope\\MacroScope.g:139:1: selectClause returns [ QueryExpression value ] : SELECT ( ALL | DISTINCT )? ( TOP Integer )? s= selectList ;
    public QueryExpression selectClause() // throws RecognitionException [1]
    {   
        QueryExpression value = default(QueryExpression);

        IToken Integer1 = null;
        AliasedItem s = default(AliasedItem);


        try 
    	{
            // MacroScope\\MacroScope.g:139:48: ( SELECT ( ALL | DISTINCT )? ( TOP Integer )? s= selectList )
            // MacroScope\\MacroScope.g:140:2: SELECT ( ALL | DISTINCT )? ( TOP Integer )? s= selectList
            {
            	Match(input,SELECT,FOLLOW_SELECT_in_selectClause694); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new QueryExpression(); 
            	}
            	// MacroScope\\MacroScope.g:141:2: ( ALL | DISTINCT )?
            	int alt17 = 3;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == ALL) )
            	{
            	    alt17 = 1;
            	}
            	else if ( (LA17_0 == DISTINCT) )
            	{
            	    alt17 = 2;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:141:4: ALL
            	        {
            	        	Match(input,ALL,FOLLOW_ALL_in_selectClause701); if (state.failed) return value;

            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:141:10: DISTINCT
            	        {
            	        	Match(input,DISTINCT,FOLLOW_DISTINCT_in_selectClause705); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.Distinct = true; 
            	        	}

            	        }
            	        break;

            	}

            	// MacroScope\\MacroScope.g:142:2: ( TOP Integer )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == TOP) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:142:3: TOP Integer
            	        {
            	        	Match(input,TOP,FOLLOW_TOP_in_selectClause714); if (state.failed) return value;
            	        	Integer1=(IToken)Match(input,Integer,FOLLOW_Integer_in_selectClause716); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.SetLimit('T', int.Parse(((Integer1 != null) ? Integer1.Text : null))); 
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_selectList_in_selectClause728);
            	s = selectList();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value.SelectItems = s; 
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "selectClause"


    // $ANTLR start "whereClause"
    // MacroScope\\MacroScope.g:146:1: whereClause returns [ IExpression value ] : WHERE c= searchCondition ;
    public IExpression whereClause() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        IExpression c = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:146:43: ( WHERE c= searchCondition )
            // MacroScope\\MacroScope.g:147:2: WHERE c= searchCondition
            {
            	Match(input,WHERE,FOLLOW_WHERE_in_whereClause745); if (state.failed) return value;
            	PushFollow(FOLLOW_searchCondition_in_whereClause751);
            	c = searchCondition();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  c; 
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "whereClause"


    // $ANTLR start "orderByClause"
    // MacroScope\\MacroScope.g:150:1: orderByClause returns [ OrderExpression value ] : ORDER BY e= orderExpression ( COMMA e= orderExpression )* ;
    public OrderExpression orderByClause() // throws RecognitionException [1]
    {   
        OrderExpression value = default(OrderExpression);

        OrderExpression e = default(OrderExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:150:49: ( ORDER BY e= orderExpression ( COMMA e= orderExpression )* )
            // MacroScope\\MacroScope.g:151:2: ORDER BY e= orderExpression ( COMMA e= orderExpression )*
            {
            	Match(input,ORDER,FOLLOW_ORDER_in_orderByClause768); if (state.failed) return value;
            	Match(input,BY,FOLLOW_BY_in_orderByClause770); if (state.failed) return value;
            	PushFollow(FOLLOW_orderExpression_in_orderByClause777);
            	e = orderExpression();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  e; 
            	}
            	// MacroScope\\MacroScope.g:153:2: ( COMMA e= orderExpression )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == COMMA) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:153:4: COMMA e= orderExpression
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_orderByClause784); if (state.failed) return value;
            			    	PushFollow(FOLLOW_orderExpression_in_orderByClause790);
            			    	e = orderExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   value.Add(e); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "orderByClause"


    // $ANTLR start "orderExpression"
    // MacroScope\\MacroScope.g:156:1: orderExpression returns [ OrderExpression value ] : e= expression ( ASC | DESC )? ;
    public OrderExpression orderExpression() // throws RecognitionException [1]
    {   
        OrderExpression value = default(OrderExpression);

        IExpression e = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:156:51: (e= expression ( ASC | DESC )? )
            // MacroScope\\MacroScope.g:157:2: e= expression ( ASC | DESC )?
            {
            	PushFollow(FOLLOW_expression_in_orderExpression814);
            	e = expression();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new OrderExpression(e); 
            	}
            	// MacroScope\\MacroScope.g:158:2: ( ASC | DESC )?
            	int alt20 = 3;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == ASC) )
            	{
            	    alt20 = 1;
            	}
            	else if ( (LA20_0 == DESC) )
            	{
            	    alt20 = 2;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:158:4: ASC
            	        {
            	        	Match(input,ASC,FOLLOW_ASC_in_orderExpression821); if (state.failed) return value;

            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:158:10: DESC
            	        {
            	        	Match(input,DESC,FOLLOW_DESC_in_orderExpression825); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.Asc = false; 
            	        	}

            	        }
            	        break;

            	}


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "orderExpression"


    // $ANTLR start "groupByClause"
    // MacroScope\\MacroScope.g:161:1: groupByClause returns [ GroupByClause value ] : GROUP BY ( ALL )? e= expression ( COMMA e= expression )* ;
    public GroupByClause groupByClause() // throws RecognitionException [1]
    {   
        GroupByClause value = default(GroupByClause);

        IExpression e = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:161:47: ( GROUP BY ( ALL )? e= expression ( COMMA e= expression )* )
            // MacroScope\\MacroScope.g:162:2: GROUP BY ( ALL )? e= expression ( COMMA e= expression )*
            {
            	Match(input,GROUP,FOLLOW_GROUP_in_groupByClause845); if (state.failed) return value;
            	Match(input,BY,FOLLOW_BY_in_groupByClause847); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new GroupByClause(); 
            	}
            	// MacroScope\\MacroScope.g:163:3: ( ALL )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( (LA21_0 == ALL) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:163:5: ALL
            	        {
            	        	Match(input,ALL,FOLLOW_ALL_in_groupByClause855); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.All = true; 
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_expression_in_groupByClause868);
            	e = expression();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  			value.Expression = new ExpressionItem(e);
            	  		
            	}
            	// MacroScope\\MacroScope.g:166:5: ( COMMA e= expression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == COMMA) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:166:7: COMMA e= expression
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_groupByClause874); if (state.failed) return value;
            			    	PushFollow(FOLLOW_expression_in_groupByClause880);
            			    	e = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  				value.Expression.Add(
            			    	  					new ExpressionItem(e));
            			    	  			
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "groupByClause"


    // $ANTLR start "havingClause"
    // MacroScope\\MacroScope.g:172:1: havingClause returns [ IExpression value ] : HAVING c= searchCondition ;
    public IExpression havingClause() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        IExpression c = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:172:44: ( HAVING c= searchCondition )
            // MacroScope\\MacroScope.g:173:2: HAVING c= searchCondition
            {
            	Match(input,HAVING,FOLLOW_HAVING_in_havingClause900); if (state.failed) return value;
            	PushFollow(FOLLOW_searchCondition_in_havingClause906);
            	c = searchCondition();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  c; 
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "havingClause"


    // $ANTLR start "searchCondition"
    // MacroScope\\MacroScope.g:176:1: searchCondition returns [ IExpression value ] : e= additiveSubSearchCondition ( OR r= additiveSubSearchCondition )* ;
    public IExpression searchCondition() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        IExpression e = default(IExpression);

        IExpression r = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:176:47: (e= additiveSubSearchCondition ( OR r= additiveSubSearchCondition )* )
            // MacroScope\\MacroScope.g:177:2: e= additiveSubSearchCondition ( OR r= additiveSubSearchCondition )*
            {
            	PushFollow(FOLLOW_additiveSubSearchCondition_in_searchCondition927);
            	e = additiveSubSearchCondition();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  e; 
            	}
            	// MacroScope\\MacroScope.g:178:3: ( OR r= additiveSubSearchCondition )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == OR) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:178:5: OR r= additiveSubSearchCondition
            			    {
            			    	Match(input,OR,FOLLOW_OR_in_searchCondition935); if (state.failed) return value;
            			    	PushFollow(FOLLOW_additiveSubSearchCondition_in_searchCondition941);
            			    	r = additiveSubSearchCondition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  			value =  new Expression(value,
            			    	  				ExpressionOperator.Or,
            			    	  				r);
            			    	  		
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "searchCondition"


    // $ANTLR start "additiveSubSearchCondition"
    // MacroScope\\MacroScope.g:186:1: additiveSubSearchCondition returns [ IExpression value ] : e= subSearchCondition ( AND r= subSearchCondition )* ;
    public IExpression additiveSubSearchCondition() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        IExpression e = default(IExpression);

        IExpression r = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:186:58: (e= subSearchCondition ( AND r= subSearchCondition )* )
            // MacroScope\\MacroScope.g:187:2: e= subSearchCondition ( AND r= subSearchCondition )*
            {
            	PushFollow(FOLLOW_subSearchCondition_in_additiveSubSearchCondition967);
            	e = subSearchCondition();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  e; 
            	}
            	// MacroScope\\MacroScope.g:188:3: ( AND r= subSearchCondition )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == AND) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:188:5: AND r= subSearchCondition
            			    {
            			    	Match(input,AND,FOLLOW_AND_in_additiveSubSearchCondition975); if (state.failed) return value;
            			    	PushFollow(FOLLOW_subSearchCondition_in_additiveSubSearchCondition981);
            			    	r = subSearchCondition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  			value =  new Expression(value,
            			    	  				ExpressionOperator.And,
            			    	  				r);
            			    	  		
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "additiveSubSearchCondition"


    // $ANTLR start "bracketedSearchCondition"
    // MacroScope\\MacroScope.g:196:1: bracketedSearchCondition returns [ IExpression value ] : LPAREN e= searchCondition RPAREN ;
    public IExpression bracketedSearchCondition() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        IExpression e = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:196:56: ( LPAREN e= searchCondition RPAREN )
            // MacroScope\\MacroScope.g:197:2: LPAREN e= searchCondition RPAREN
            {
            	Match(input,LPAREN,FOLLOW_LPAREN_in_bracketedSearchCondition1003); if (state.failed) return value;
            	PushFollow(FOLLOW_searchCondition_in_bracketedSearchCondition1009);
            	e = searchCondition();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	Match(input,RPAREN,FOLLOW_RPAREN_in_bracketedSearchCondition1011); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  		value =  e;
            	  	
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "bracketedSearchCondition"


    // $ANTLR start "subSearchCondition"
    // MacroScope\\MacroScope.g:202:1: subSearchCondition returns [ IExpression value ] : ( NOT )? ( ( bracketedSearchCondition )=>e= bracketedSearchCondition | p= predicate ) ;
    public IExpression subSearchCondition() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        IExpression e = default(IExpression);

        IExpression p = default(IExpression);


         bool negated = false; 
        try 
    	{
            // MacroScope\\MacroScope.g:203:33: ( ( NOT )? ( ( bracketedSearchCondition )=>e= bracketedSearchCondition | p= predicate ) )
            // MacroScope\\MacroScope.g:204:2: ( NOT )? ( ( bracketedSearchCondition )=>e= bracketedSearchCondition | p= predicate )
            {
            	// MacroScope\\MacroScope.g:204:2: ( NOT )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( (LA25_0 == NOT) )
            	{
            	    alt25 = 1;
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:204:4: NOT
            	        {
            	        	Match(input,NOT,FOLLOW_NOT_in_subSearchCondition1035); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   negated = true; 
            	        	}

            	        }
            	        break;

            	}

            	// MacroScope\\MacroScope.g:204:31: ( ( bracketedSearchCondition )=>e= bracketedSearchCondition | p= predicate )
            	int alt26 = 2;
            	alt26 = dfa26.Predict(input);
            	switch (alt26) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:205:3: ( bracketedSearchCondition )=>e= bracketedSearchCondition
            	        {
            	        	PushFollow(FOLLOW_bracketedSearchCondition_in_subSearchCondition1059);
            	        	e = bracketedSearchCondition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  				if (!negated)
            	        	  				{
            	        	  					value =  e;
            	        	  				}
            	        	  				else
            	        	  				{
            	        	  					Expression output = new Expression();
            	        	  					output.Operator =
            	        	  						ExpressionOperator.Not;
            	        	  					output.Right = e;
            	        	  					value =  output;
            	        	  				}
            	        	  		
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:220:5: p= predicate
            	        {
            	        	PushFollow(FOLLOW_predicate_in_subSearchCondition1071);
            	        	p = predicate();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			if (!negated)
            	        	  			{
            	        	  				value =  p;
            	        	  			}
            	        	  			else
            	        	  			{
            	        	  				Expression output = new Expression();
            	        	  				output.Operator = ExpressionOperator.Not;
            	        	  				output.Right = p;
            	        	  				value =  output;
            	        	  			}
            	        	  		
            	        	}

            	        }
            	        break;

            	}


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "subSearchCondition"


    // $ANTLR start "predicate"
    // MacroScope\\MacroScope.g:236:1: predicate returns [ IExpression value ] : (l= expression (o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN ) | IS ( NOT )? NULL | ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN ) ) | EXISTS LPAREN s= selectStatement RPAREN );
    public IExpression predicate() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        IExpression l = default(IExpression);

        ExpressionOperator o = default(ExpressionOperator);

        IExpression r = default(IExpression);

        PredicateQuantifier q = default(PredicateQuantifier);

        SelectStatement s = default(SelectStatement);

        IExpression e = default(IExpression);

        IExpression f = default(IExpression);



        	bool negated = false; 
        	ExpressionItem inSet = null;

        try 
    	{
            // MacroScope\\MacroScope.g:240:3: (l= expression (o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN ) | IS ( NOT )? NULL | ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN ) ) | EXISTS LPAREN s= selectStatement RPAREN )
            int alt35 = 2;
            int LA35_0 = input.LA(1);

            if ( (LA35_0 == LPAREN || LA35_0 == Integer || LA35_0 == NULL || (LA35_0 >= LEFT && LA35_0 <= RIGHT) || (LA35_0 >= PLACEHOLDER && LA35_0 <= SUBSTRING) || (LA35_0 >= EXTRACT && LA35_0 <= CASE) || LA35_0 == CAST || (LA35_0 >= UnicodeStringLiteral && LA35_0 <= MINUS)) )
            {
                alt35 = 1;
            }
            else if ( (LA35_0 == EXISTS) )
            {
                alt35 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d35s0 =
                    new NoViableAltException("", 35, 0, input);

                throw nvae_d35s0;
            }
            switch (alt35) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:241:2: l= expression (o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN ) | IS ( NOT )? NULL | ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN ) )
                    {
                    	PushFollow(FOLLOW_expression_in_predicate1101);
                    	l = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	// MacroScope\\MacroScope.g:241:17: (o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN ) | IS ( NOT )? NULL | ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN ) )
                    	int alt34 = 3;
                    	switch ( input.LA(1) ) 
                    	{
                    	case ASSIGNEQUAL:
                    	case NOTEQUAL1:
                    	case NOTEQUAL2:
                    	case LESSTHANOREQUALTO1:
                    	case LESSTHAN:
                    	case GREATERTHANOREQUALTO1:
                    	case GREATERTHAN:
                    		{
                    	    alt34 = 1;
                    	    }
                    	    break;
                    	case IS:
                    		{
                    	    alt34 = 2;
                    	    }
                    	    break;
                    	case NOT:
                    	case LIKE:
                    	case BETWEEN:
                    	case IN:
                    		{
                    	    alt34 = 3;
                    	    }
                    	    break;
                    		default:
                    		    if ( state.backtracking > 0 ) {state.failed = true; return value;}
                    		    NoViableAltException nvae_d34s0 =
                    		        new NoViableAltException("", 34, 0, input);

                    		    throw nvae_d34s0;
                    	}

                    	switch (alt34) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:242:10: o= comparisonOperator (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN )
                    	        {
                    	        	PushFollow(FOLLOW_comparisonOperator_in_predicate1118);
                    	        	o = comparisonOperator();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return value;
                    	        	// MacroScope\\MacroScope.g:242:33: (r= expression | q= quantifierSpec LPAREN s= selectStatement RPAREN )
                    	        	int alt27 = 2;
                    	        	int LA27_0 = input.LA(1);

                    	        	if ( (LA27_0 == LPAREN || LA27_0 == Integer || LA27_0 == NULL || (LA27_0 >= LEFT && LA27_0 <= RIGHT) || (LA27_0 >= PLACEHOLDER && LA27_0 <= SUBSTRING) || (LA27_0 >= EXTRACT && LA27_0 <= CASE) || LA27_0 == CAST || (LA27_0 >= UnicodeStringLiteral && LA27_0 <= MINUS)) )
                    	        	{
                    	        	    alt27 = 1;
                    	        	}
                    	        	else if ( (LA27_0 == ALL || (LA27_0 >= SOME && LA27_0 <= ANY)) )
                    	        	{
                    	        	    alt27 = 2;
                    	        	}
                    	        	else 
                    	        	{
                    	        	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
                    	        	    NoViableAltException nvae_d27s0 =
                    	        	        new NoViableAltException("", 27, 0, input);

                    	        	    throw nvae_d27s0;
                    	        	}
                    	        	switch (alt27) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:243:15: r= expression
                    	        	        {
                    	        	        	PushFollow(FOLLOW_expression_in_predicate1140);
                    	        	        	r = expression();
                    	        	        	state.followingStackPointer--;
                    	        	        	if (state.failed) return value;
                    	        	        	if ( (state.backtracking==0) )
                    	        	        	{

                    	        	        	  				value =  new Expression(l,
                    	        	        	  					o, r);
                    	        	        	  			
                    	        	        	}

                    	        	        }
                    	        	        break;
                    	        	    case 2 :
                    	        	        // MacroScope\\MacroScope.g:247:6: q= quantifierSpec LPAREN s= selectStatement RPAREN
                    	        	        {
                    	        	        	PushFollow(FOLLOW_quantifierSpec_in_predicate1153);
                    	        	        	q = quantifierSpec();
                    	        	        	state.followingStackPointer--;
                    	        	        	if (state.failed) return value;
                    	        	        	Match(input,LPAREN,FOLLOW_LPAREN_in_predicate1159); if (state.failed) return value;
                    	        	        	PushFollow(FOLLOW_selectStatement_in_predicate1165);
                    	        	        	s = selectStatement();
                    	        	        	state.followingStackPointer--;
                    	        	        	if (state.failed) return value;
                    	        	        	Match(input,RPAREN,FOLLOW_RPAREN_in_predicate1167); if (state.failed) return value;
                    	        	        	if ( (state.backtracking==0) )
                    	        	        	{

                    	        	        	  					BracketedExpression expr =
                    	        	        	  						new BracketedExpression(
                    	        	        	  							s);
                    	        	        	  					expr.Spaced = true;
                    	        	        	  					value =  new PredicateExpression(
                    	        	        	  						l, o,
                    	        	        	  						q, expr);
                    	        	        	  				
                    	        	        	}

                    	        	        }
                    	        	        break;

                    	        	}


                    	        }
                    	        break;
                    	    case 2 :
                    	        // MacroScope\\MacroScope.g:258:5: IS ( NOT )? NULL
                    	        {
                    	        	Match(input,IS,FOLLOW_IS_in_predicate1188); if (state.failed) return value;
                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	  			value =  new Expression();
                    	        	  			((Expression)value).Left = l;
                    	        	  			((Expression)value).Operator =
                    	        	  				ExpressionOperator.IsNull;
                    	        	  		
                    	        	}
                    	        	// MacroScope\\MacroScope.g:264:4: ( NOT )?
                    	        	int alt28 = 2;
                    	        	int LA28_0 = input.LA(1);

                    	        	if ( (LA28_0 == NOT) )
                    	        	{
                    	        	    alt28 = 1;
                    	        	}
                    	        	switch (alt28) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:264:6: NOT
                    	        	        {
                    	        	        	Match(input,NOT,FOLLOW_NOT_in_predicate1198); if (state.failed) return value;
                    	        	        	if ( (state.backtracking==0) )
                    	        	        	{

                    	        	        	  				((Expression)value).Operator =
                    	        	        	  					ExpressionOperator.IsNotNull;
                    	        	        	  			
                    	        	        	}

                    	        	        }
                    	        	        break;

                    	        	}

                    	        	Match(input,NULL,FOLLOW_NULL_in_predicate1208); if (state.failed) return value;

                    	        }
                    	        break;
                    	    case 3 :
                    	        // MacroScope\\MacroScope.g:269:5: ( NOT )? ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN )
                    	        {
                    	        	// MacroScope\\MacroScope.g:269:5: ( NOT )?
                    	        	int alt29 = 2;
                    	        	int LA29_0 = input.LA(1);

                    	        	if ( (LA29_0 == NOT) )
                    	        	{
                    	        	    alt29 = 1;
                    	        	}
                    	        	switch (alt29) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:269:7: NOT
                    	        	        {
                    	        	        	Match(input,NOT,FOLLOW_NOT_in_predicate1216); if (state.failed) return value;
                    	        	        	if ( (state.backtracking==0) )
                    	        	        	{
                    	        	        	   negated = true; 
                    	        	        	}

                    	        	        }
                    	        	        break;

                    	        	}

                    	        	// MacroScope\\MacroScope.g:269:34: ( LIKE e= expression ( ESCAPE f= expression )? | BETWEEN e= expression AND f= expression | IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN )
                    	        	int alt33 = 3;
                    	        	switch ( input.LA(1) ) 
                    	        	{
                    	        	case LIKE:
                    	        		{
                    	        	    alt33 = 1;
                    	        	    }
                    	        	    break;
                    	        	case BETWEEN:
                    	        		{
                    	        	    alt33 = 2;
                    	        	    }
                    	        	    break;
                    	        	case IN:
                    	        		{
                    	        	    alt33 = 3;
                    	        	    }
                    	        	    break;
                    	        		default:
                    	        		    if ( state.backtracking > 0 ) {state.failed = true; return value;}
                    	        		    NoViableAltException nvae_d33s0 =
                    	        		        new NoViableAltException("", 33, 0, input);

                    	        		    throw nvae_d33s0;
                    	        	}

                    	        	switch (alt33) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:270:4: LIKE e= expression ( ESCAPE f= expression )?
                    	        	        {
                    	        	        	Match(input,LIKE,FOLLOW_LIKE_in_predicate1228); if (state.failed) return value;
                    	        	        	PushFollow(FOLLOW_expression_in_predicate1234);
                    	        	        	e = expression();
                    	        	        	state.followingStackPointer--;
                    	        	        	if (state.failed) return value;
                    	        	        	if ( (state.backtracking==0) )
                    	        	        	{

                    	        	        	  				value =  new PatternExpression(
                    	        	        	  					e);
                    	        	        	  			
                    	        	        	}
                    	        	        	// MacroScope\\MacroScope.g:275:5: ( ESCAPE f= expression )?
                    	        	        	int alt30 = 2;
                    	        	        	int LA30_0 = input.LA(1);

                    	        	        	if ( (LA30_0 == ESCAPE) )
                    	        	        	{
                    	        	        	    alt30 = 1;
                    	        	        	}
                    	        	        	switch (alt30) 
                    	        	        	{
                    	        	        	    case 1 :
                    	        	        	        // MacroScope\\MacroScope.g:275:7: ESCAPE f= expression
                    	        	        	        {
                    	        	        	        	Match(input,ESCAPE,FOLLOW_ESCAPE_in_predicate1249); if (state.failed) return value;
                    	        	        	        	PushFollow(FOLLOW_expression_in_predicate1255);
                    	        	        	        	f = expression();
                    	        	        	        	state.followingStackPointer--;
                    	        	        	        	if (state.failed) return value;
                    	        	        	        	if ( (state.backtracking==0) )
                    	        	        	        	{

                    	        	        	        	  					((PatternExpression)value).Escape =
                    	        	        	        	  						f;
                    	        	        	        	  				
                    	        	        	        	}

                    	        	        	        }
                    	        	        	        break;

                    	        	        	}

                    	        	        	if ( (state.backtracking==0) )
                    	        	        	{

                    	        	        	  					if (!negated)
                    	        	        	  					{
                    	        	        	  						value =  new Expression(l, ExpressionOperator.Like, value);
                    	        	        	  					}
                    	        	        	  					else
                    	        	        	  					{
                    	        	        	  						value =  new Expression(l, ExpressionOperator.NotLike, value);
                    	        	        	  					}
                    	        	        	  				
                    	        	        	}

                    	        	        }
                    	        	        break;
                    	        	    case 2 :
                    	        	        // MacroScope\\MacroScope.g:289:6: BETWEEN e= expression AND f= expression
                    	        	        {
                    	        	        	Match(input,BETWEEN,FOLLOW_BETWEEN_in_predicate1273); if (state.failed) return value;
                    	        	        	PushFollow(FOLLOW_expression_in_predicate1279);
                    	        	        	e = expression();
                    	        	        	state.followingStackPointer--;
                    	        	        	if (state.failed) return value;
                    	        	        	Match(input,AND,FOLLOW_AND_in_predicate1281); if (state.failed) return value;
                    	        	        	PushFollow(FOLLOW_expression_in_predicate1287);
                    	        	        	f = expression();
                    	        	        	state.followingStackPointer--;
                    	        	        	if (state.failed) return value;
                    	        	        	if ( (state.backtracking==0) )
                    	        	        	{

                    	        	        	  				Expression inner = new Expression(l,
                    	        	        	  					ExpressionOperator.Between,
                    	        	        	  					new Range(e, f));
                    	        	        	  				if (!negated)
                    	        	        	  				{
                    	        	        	  					value =  inner;
                    	        	        	  				}
                    	        	        	  				else
                    	        	        	  				{
                    	        	        	  					value =  new Expression();
                    	        	        	  					((Expression)value).Operator =
                    	        	        	  						ExpressionOperator.Not;
                    	        	        	  					((Expression)value).Right = inner;
                    	        	        	  				}
                    	        	        	  			
                    	        	        	}

                    	        	        }
                    	        	        break;
                    	        	    case 3 :
                    	        	        // MacroScope\\MacroScope.g:305:6: IN LPAREN ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* ) RPAREN
                    	        	        {
                    	        	        	Match(input,IN,FOLLOW_IN_in_predicate1296); if (state.failed) return value;
                    	        	        	Match(input,LPAREN,FOLLOW_LPAREN_in_predicate1298); if (state.failed) return value;
                    	        	        	// MacroScope\\MacroScope.g:305:16: ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* )
                    	        	        	int alt32 = 2;
                    	        	        	alt32 = dfa32.Predict(input);
                    	        	        	switch (alt32) 
                    	        	        	{
                    	        	        	    case 1 :
                    	        	        	        // MacroScope\\MacroScope.g:306:5: ( selectStatement )=>s= selectStatement
                    	        	        	        {
                    	        	        	        	PushFollow(FOLLOW_selectStatement_in_predicate1323);
                    	        	        	        	s = selectStatement();
                    	        	        	        	state.followingStackPointer--;
                    	        	        	        	if (state.failed) return value;
                    	        	        	        	if ( (state.backtracking==0) )
                    	        	        	        	{

                    	        	        	        	  						value =  new Expression(l, negated ? ExpressionOperator.NotIn : ExpressionOperator.In, s);
                    	        	        	        	  					
                    	        	        	        	}

                    	        	        	        }
                    	        	        	        break;
                    	        	        	    case 2 :
                    	        	        	        // MacroScope\\MacroScope.g:310:7: e= expression ( COMMA e= expression )*
                    	        	        	        {
                    	        	        	        	PushFollow(FOLLOW_expression_in_predicate1337);
                    	        	        	        	e = expression();
                    	        	        	        	state.followingStackPointer--;
                    	        	        	        	if (state.failed) return value;
                    	        	        	        	if ( (state.backtracking==0) )
                    	        	        	        	{

                    	        	        	        	  					inSet = new ExpressionItem(e);
                    	        	        	        	  				
                    	        	        	        	}
                    	        	        	        	// MacroScope\\MacroScope.g:313:6: ( COMMA e= expression )*
                    	        	        	        	do 
                    	        	        	        	{
                    	        	        	        	    int alt31 = 2;
                    	        	        	        	    int LA31_0 = input.LA(1);

                    	        	        	        	    if ( (LA31_0 == COMMA) )
                    	        	        	        	    {
                    	        	        	        	        alt31 = 1;
                    	        	        	        	    }


                    	        	        	        	    switch (alt31) 
                    	        	        	        		{
                    	        	        	        			case 1 :
                    	        	        	        			    // MacroScope\\MacroScope.g:313:8: COMMA e= expression
                    	        	        	        			    {
                    	        	        	        			    	Match(input,COMMA,FOLLOW_COMMA_in_predicate1348); if (state.failed) return value;
                    	        	        	        			    	PushFollow(FOLLOW_expression_in_predicate1354);
                    	        	        	        			    	e = expression();
                    	        	        	        			    	state.followingStackPointer--;
                    	        	        	        			    	if (state.failed) return value;
                    	        	        	        			    	if ( (state.backtracking==0) )
                    	        	        	        			    	{

                    	        	        	        			    	  						inSet.Add(new ExpressionItem(
                    	        	        	        			    	  							e));
                    	        	        	        			    	  					
                    	        	        	        			    	}

                    	        	        	        			    }
                    	        	        	        			    break;

                    	        	        	        			default:
                    	        	        	        			    goto loop31;
                    	        	        	        	    }
                    	        	        	        	} while (true);

                    	        	        	        	loop31:
                    	        	        	        		;	// Stops C# compiler whining that label 'loop31' has no statements


                    	        	        	        }
                    	        	        	        break;

                    	        	        	}

                    	        	        	Match(input,RPAREN,FOLLOW_RPAREN_in_predicate1367); if (state.failed) return value;
                    	        	        	if ( (state.backtracking==0) )
                    	        	        	{

                    	        	        	  					if (value == null)
                    	        	        	  					{
                    	        	        	  						value =  new Expression(l, negated ? ExpressionOperator.NotIn : ExpressionOperator.In, inSet);
                    	        	        	  					}
                    	        	        	  				
                    	        	        	}

                    	        	        }
                    	        	        break;

                    	        	}


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:325:4: EXISTS LPAREN s= selectStatement RPAREN
                    {
                    	Match(input,EXISTS,FOLLOW_EXISTS_in_predicate1382); if (state.failed) return value;
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_predicate1384); if (state.failed) return value;
                    	PushFollow(FOLLOW_selectStatement_in_predicate1390);
                    	s = selectStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	Match(input,RPAREN,FOLLOW_RPAREN_in_predicate1392); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new Expression();
                    	  		((Expression)value).Operator = ExpressionOperator.Exists;
                    	  		((Expression)value).Right = s;
                    	  	
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "predicate"


    // $ANTLR start "quantifierSpec"
    // MacroScope\\MacroScope.g:332:1: quantifierSpec returns [ PredicateQuantifier value ] : ( ALL | SOME | ANY );
    public PredicateQuantifier quantifierSpec() // throws RecognitionException [1]
    {   
        PredicateQuantifier value = default(PredicateQuantifier);

        try 
    	{
            // MacroScope\\MacroScope.g:332:54: ( ALL | SOME | ANY )
            int alt36 = 3;
            switch ( input.LA(1) ) 
            {
            case ALL:
            	{
                alt36 = 1;
                }
                break;
            case SOME:
            	{
                alt36 = 2;
                }
                break;
            case ANY:
            	{
                alt36 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	    NoViableAltException nvae_d36s0 =
            	        new NoViableAltException("", 36, 0, input);

            	    throw nvae_d36s0;
            }

            switch (alt36) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:333:2: ALL
                    {
                    	Match(input,ALL,FOLLOW_ALL_in_quantifierSpec1409); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  PredicateQuantifier.All; 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:334:4: SOME
                    {
                    	Match(input,SOME,FOLLOW_SOME_in_quantifierSpec1416); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  PredicateQuantifier.Any; 
                    	}

                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:335:4: ANY
                    {
                    	Match(input,ANY,FOLLOW_ANY_in_quantifierSpec1423); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  PredicateQuantifier.Any; 
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "quantifierSpec"


    // $ANTLR start "selectList"
    // MacroScope\\MacroScope.g:338:1: selectList returns [ AliasedItem value ] : s= selectItem ( COMMA t= selectItem )* ;
    public AliasedItem selectList() // throws RecognitionException [1]
    {   
        AliasedItem value = default(AliasedItem);

        AliasedItem s = default(AliasedItem);

        AliasedItem t = default(AliasedItem);


        try 
    	{
            // MacroScope\\MacroScope.g:338:42: (s= selectItem ( COMMA t= selectItem )* )
            // MacroScope\\MacroScope.g:339:2: s= selectItem ( COMMA t= selectItem )*
            {
            	PushFollow(FOLLOW_selectItem_in_selectList1444);
            	s = selectItem();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  s; 
            	}
            	// MacroScope\\MacroScope.g:340:3: ( COMMA t= selectItem )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == COMMA) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:340:5: COMMA t= selectItem
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_selectList1452); if (state.failed) return value;
            			    	PushFollow(FOLLOW_selectItem_in_selectList1458);
            			    	t = selectItem();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   value.Add(t); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "selectList"


    // $ANTLR start "selectItem"
    // MacroScope\\MacroScope.g:343:1: selectItem returns [ AliasedItem value ] : ( STAR | ( ( alias2 )=> (a= alias2 e= expression ) | ( tableColumns )=>t= tableColumns | e= expression (a= alias1 )? ) );
    public AliasedItem selectItem() // throws RecognitionException [1]
    {   
        AliasedItem value = default(AliasedItem);

        Identifier a = default(Identifier);

        IExpression e = default(IExpression);

        TableWildcard t = default(TableWildcard);


        try 
    	{
            // MacroScope\\MacroScope.g:343:42: ( STAR | ( ( alias2 )=> (a= alias2 e= expression ) | ( tableColumns )=>t= tableColumns | e= expression (a= alias1 )? ) )
            int alt40 = 2;
            int LA40_0 = input.LA(1);

            if ( (LA40_0 == STAR) )
            {
                alt40 = 1;
            }
            else if ( (LA40_0 == LPAREN || LA40_0 == Integer || LA40_0 == NULL || (LA40_0 >= LEFT && LA40_0 <= RIGHT) || (LA40_0 >= PLACEHOLDER && LA40_0 <= SUBSTRING) || (LA40_0 >= EXTRACT && LA40_0 <= CASE) || LA40_0 == CAST || (LA40_0 >= UnicodeStringLiteral && LA40_0 <= MINUS)) )
            {
                alt40 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d40s0 =
                    new NoViableAltException("", 40, 0, input);

                throw nvae_d40s0;
            }
            switch (alt40) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:344:2: STAR
                    {
                    	Match(input,STAR,FOLLOW_STAR_in_selectItem1478); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new AliasedItem(Wildcard.Value);
                    	  	
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:347:4: ( ( alias2 )=> (a= alias2 e= expression ) | ( tableColumns )=>t= tableColumns | e= expression (a= alias1 )? )
                    {
                    	// MacroScope\\MacroScope.g:347:4: ( ( alias2 )=> (a= alias2 e= expression ) | ( tableColumns )=>t= tableColumns | e= expression (a= alias1 )? )
                    	int alt39 = 3;
                    	alt39 = dfa39.Predict(input);
                    	switch (alt39) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:349:3: ( alias2 )=> (a= alias2 e= expression )
                    	        {
                    	        	// MacroScope\\MacroScope.g:349:15: (a= alias2 e= expression )
                    	        	// MacroScope\\MacroScope.g:350:4: a= alias2 e= expression
                    	        	{
                    	        		PushFollow(FOLLOW_alias2_in_selectItem1508);
                    	        		a = alias2();
                    	        		state.followingStackPointer--;
                    	        		if (state.failed) return value;
                    	        		PushFollow(FOLLOW_expression_in_selectItem1514);
                    	        		e = expression();
                    	        		state.followingStackPointer--;
                    	        		if (state.failed) return value;
                    	        		if ( (state.backtracking==0) )
                    	        		{

                    	        		  				value =  new AliasedItem(e);
                    	        		  				value.Alias = a;
                    	        		  			
                    	        		}

                    	        	}


                    	        }
                    	        break;
                    	    case 2 :
                    	        // MacroScope\\MacroScope.g:357:5: ( tableColumns )=>t= tableColumns
                    	        {
                    	        	PushFollow(FOLLOW_tableColumns_in_selectItem1540);
                    	        	t = tableColumns();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return value;
                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	  			value =  new AliasedItem(t);
                    	        	  		
                    	        	}

                    	        }
                    	        break;
                    	    case 3 :
                    	        // MacroScope\\MacroScope.g:361:5: e= expression (a= alias1 )?
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_selectItem1553);
                    	        	e = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return value;
                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	  			value =  new AliasedItem(e);
                    	        	  		
                    	        	}
                    	        	// MacroScope\\MacroScope.g:364:4: (a= alias1 )?
                    	        	int alt38 = 2;
                    	        	int LA38_0 = input.LA(1);

                    	        	if ( (LA38_0 == AS || LA38_0 == NonQuotedIdentifier || LA38_0 == QuotedIdentifier) )
                    	        	{
                    	        	    alt38 = 1;
                    	        	}
                    	        	switch (alt38) 
                    	        	{
                    	        	    case 1 :
                    	        	        // MacroScope\\MacroScope.g:364:6: a= alias1
                    	        	        {
                    	        	        	PushFollow(FOLLOW_alias1_in_selectItem1566);
                    	        	        	a = alias1();
                    	        	        	state.followingStackPointer--;
                    	        	        	if (state.failed) return value;
                    	        	        	if ( (state.backtracking==0) )
                    	        	        	{
                    	        	        	   value.Alias = a; 
                    	        	        	}

                    	        	        }
                    	        	        break;

                    	        	}


                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "selectItem"


    // $ANTLR start "fromClause"
    // MacroScope\\MacroScope.g:368:1: fromClause returns [ AliasedItem value ] : FROM t= tableSource ( COMMA t= tableSource )* ;
    public AliasedItem fromClause() // throws RecognitionException [1]
    {   
        AliasedItem value = default(AliasedItem);

        Table t = default(Table);


        try 
    	{
            // MacroScope\\MacroScope.g:368:42: ( FROM t= tableSource ( COMMA t= tableSource )* )
            // MacroScope\\MacroScope.g:369:2: FROM t= tableSource ( COMMA t= tableSource )*
            {
            	Match(input,FROM,FOLLOW_FROM_in_fromClause1589); if (state.failed) return value;
            	PushFollow(FOLLOW_tableSource_in_fromClause1595);
            	t = tableSource();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new AliasedItem(t); 
            	}
            	// MacroScope\\MacroScope.g:370:2: ( COMMA t= tableSource )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( (LA41_0 == COMMA) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:370:4: COMMA t= tableSource
            			    {
            			    	Match(input,COMMA,FOLLOW_COMMA_in_fromClause1602); if (state.failed) return value;
            			    	PushFollow(FOLLOW_tableSource_in_fromClause1608);
            			    	t = tableSource();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  		value.Add(new AliasedItem(t));
            			    	  	
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "fromClause"


    // $ANTLR start "tableSource"
    // MacroScope\\MacroScope.g:375:1: tableSource returns [ Table value ] : t= subTableSource (t= joinedTable )* ;
    public Table tableSource() // throws RecognitionException [1]
    {   
        Table value = default(Table);

        Table t = default(Table);


        try 
    	{
            // MacroScope\\MacroScope.g:375:37: (t= subTableSource (t= joinedTable )* )
            // MacroScope\\MacroScope.g:376:2: t= subTableSource (t= joinedTable )*
            {
            	PushFollow(FOLLOW_subTableSource_in_tableSource1632);
            	t = subTableSource();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  t; 
            	}
            	// MacroScope\\MacroScope.g:377:2: (t= joinedTable )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( ((LA42_0 >= INNER && LA42_0 <= FULL) || (LA42_0 >= JOIN && LA42_0 <= CROSS)) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:377:4: t= joinedTable
            			    {
            			    	PushFollow(FOLLOW_joinedTable_in_tableSource1643);
            			    	t = joinedTable();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   value.Add(t); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "tableSource"


    // $ANTLR start "subTableSource"
    // MacroScope\\MacroScope.g:380:1: subTableSource returns [ Table value ] : ( LPAREN ( ( joinedTables )=>t= joinedTables RPAREN | q= queryExpression RPAREN a= alias1 ) | ( function )=>f= function (a= alias1 )? | o= dbObject (a= alias1 )? );
    public Table subTableSource() // throws RecognitionException [1]
    {   
        Table value = default(Table);

        Table t = default(Table);

        QueryExpression q = default(QueryExpression);

        Identifier a = default(Identifier);

        IExpression f = default(IExpression);

        DbObject o = default(DbObject);


        try 
    	{
            // MacroScope\\MacroScope.g:380:40: ( LPAREN ( ( joinedTables )=>t= joinedTables RPAREN | q= queryExpression RPAREN a= alias1 ) | ( function )=>f= function (a= alias1 )? | o= dbObject (a= alias1 )? )
            int alt46 = 3;
            int LA46_0 = input.LA(1);

            if ( (LA46_0 == LPAREN) )
            {
                alt46 = 1;
            }
            else if ( (LA46_0 == SUBSTRING) && (synpred6_MacroScope()) )
            {
                alt46 = 2;
            }
            else if ( (LA46_0 == EXTRACT) && (synpred6_MacroScope()) )
            {
                alt46 = 2;
            }
            else if ( (LA46_0 == NonQuotedIdentifier) )
            {
                int LA46_4 = input.LA(2);

                if ( (LA46_4 == EOF || LA46_4 == RPAREN || LA46_4 == COMMA || (LA46_4 >= WHERE && LA46_4 <= ORDER) || LA46_4 == GROUP || (LA46_4 >= INNER && LA46_4 <= FULL) || (LA46_4 >= JOIN && LA46_4 <= AS) || LA46_4 == NonQuotedIdentifier || LA46_4 == DOT || LA46_4 == QuotedIdentifier || LA46_4 == UNION) )
                {
                    alt46 = 3;
                }
                else if ( (LA46_4 == LPAREN) && (synpred6_MacroScope()) )
                {
                    alt46 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return value;}
                    NoViableAltException nvae_d46s4 =
                        new NoViableAltException("", 46, 4, input);

                    throw nvae_d46s4;
                }
            }
            else if ( (LA46_0 == LEFT) && (synpred6_MacroScope()) )
            {
                alt46 = 2;
            }
            else if ( (LA46_0 == RIGHT) && (synpred6_MacroScope()) )
            {
                alt46 = 2;
            }
            else if ( (LA46_0 == QuotedIdentifier) )
            {
                alt46 = 3;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d46s0 =
                    new NoViableAltException("", 46, 0, input);

                throw nvae_d46s0;
            }
            switch (alt46) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:381:2: LPAREN ( ( joinedTables )=>t= joinedTables RPAREN | q= queryExpression RPAREN a= alias1 )
                    {
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_subTableSource1663); if (state.failed) return value;
                    	// MacroScope\\MacroScope.g:381:9: ( ( joinedTables )=>t= joinedTables RPAREN | q= queryExpression RPAREN a= alias1 )
                    	int alt43 = 2;
                    	int LA43_0 = input.LA(1);

                    	if ( (LA43_0 == LPAREN) )
                    	{
                    	    int LA43_1 = input.LA(2);

                    	    if ( (synpred5_MacroScope()) )
                    	    {
                    	        alt43 = 1;
                    	    }
                    	    else if ( (true) )
                    	    {
                    	        alt43 = 2;
                    	    }
                    	    else 
                    	    {
                    	        if ( state.backtracking > 0 ) {state.failed = true; return value;}
                    	        NoViableAltException nvae_d43s1 =
                    	            new NoViableAltException("", 43, 1, input);

                    	        throw nvae_d43s1;
                    	    }
                    	}
                    	else if ( (LA43_0 == SUBSTRING) && (synpred5_MacroScope()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == EXTRACT) && (synpred5_MacroScope()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == NonQuotedIdentifier) && (synpred5_MacroScope()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == LEFT) && (synpred5_MacroScope()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == RIGHT) && (synpred5_MacroScope()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == QuotedIdentifier) && (synpred5_MacroScope()) )
                    	{
                    	    alt43 = 1;
                    	}
                    	else if ( (LA43_0 == SELECT) )
                    	{
                    	    alt43 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
                    	    NoViableAltException nvae_d43s0 =
                    	        new NoViableAltException("", 43, 0, input);

                    	    throw nvae_d43s0;
                    	}
                    	switch (alt43) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:382:3: ( joinedTables )=>t= joinedTables RPAREN
                    	        {
                    	        	PushFollow(FOLLOW_joinedTables_in_subTableSource1682);
                    	        	t = joinedTables();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return value;
                    	        	Match(input,RPAREN,FOLLOW_RPAREN_in_subTableSource1684); if (state.failed) return value;
                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	  				value =  new Table(
                    	        	  					new BracketedExpression(t));
                    	        	  			
                    	        	}

                    	        }
                    	        break;
                    	    case 2 :
                    	        // MacroScope\\MacroScope.g:388:5: q= queryExpression RPAREN a= alias1
                    	        {
                    	        	PushFollow(FOLLOW_queryExpression_in_subTableSource1699);
                    	        	q = queryExpression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return value;
                    	        	Match(input,RPAREN,FOLLOW_RPAREN_in_subTableSource1701); if (state.failed) return value;
                    	        	PushFollow(FOLLOW_alias1_in_subTableSource1707);
                    	        	a = alias1();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return value;
                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	  			BracketedExpression expr =
                    	        	  				new BracketedExpression(q);
                    	        	  			expr.Spaced = true;
                    	        	  			value =  new Table(expr);
                    	        	  			value.Alias = a;
                    	        	  		
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:399:4: ( function )=>f= function (a= alias1 )?
                    {
                    	PushFollow(FOLLOW_function_in_subTableSource1742);
                    	f = function();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			value =  new Table(f);
                    	  		
                    	}
                    	// MacroScope\\MacroScope.g:403:4: (a= alias1 )?
                    	int alt44 = 2;
                    	int LA44_0 = input.LA(1);

                    	if ( (LA44_0 == AS || LA44_0 == NonQuotedIdentifier || LA44_0 == QuotedIdentifier) )
                    	{
                    	    alt44 = 1;
                    	}
                    	switch (alt44) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:403:6: a= alias1
                    	        {
                    	        	PushFollow(FOLLOW_alias1_in_subTableSource1755);
                    	        	a = alias1();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return value;
                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	   value.Alias = a; 
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:404:4: o= dbObject (a= alias1 )?
                    {
                    	PushFollow(FOLLOW_dbObject_in_subTableSource1769);
                    	o = dbObject();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  new Table(o); 
                    	}
                    	// MacroScope\\MacroScope.g:405:3: (a= alias1 )?
                    	int alt45 = 2;
                    	int LA45_0 = input.LA(1);

                    	if ( (LA45_0 == AS || LA45_0 == NonQuotedIdentifier || LA45_0 == QuotedIdentifier) )
                    	{
                    	    alt45 = 1;
                    	}
                    	switch (alt45) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:405:5: a= alias1
                    	        {
                    	        	PushFollow(FOLLOW_alias1_in_subTableSource1781);
                    	        	a = alias1();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return value;
                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	   value.Alias = a; 
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "subTableSource"


    // $ANTLR start "joinOn"
    // MacroScope\\MacroScope.g:408:1: joinOn returns [ Join value ] : ( INNER | ( LEFT | RIGHT | FULL ) ( OUTER )? )? JOIN ;
    public Join joinOn() // throws RecognitionException [1]
    {   
        Join value = default(Join);

        try 
    	{
            // MacroScope\\MacroScope.g:408:31: ( ( INNER | ( LEFT | RIGHT | FULL ) ( OUTER )? )? JOIN )
            // MacroScope\\MacroScope.g:409:2: ( INNER | ( LEFT | RIGHT | FULL ) ( OUTER )? )? JOIN
            {
            	// MacroScope\\MacroScope.g:409:2: ( INNER | ( LEFT | RIGHT | FULL ) ( OUTER )? )?
            	int alt49 = 3;
            	int LA49_0 = input.LA(1);

            	if ( (LA49_0 == INNER) )
            	{
            	    alt49 = 1;
            	}
            	else if ( ((LA49_0 >= LEFT && LA49_0 <= FULL)) )
            	{
            	    alt49 = 2;
            	}
            	switch (alt49) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:409:4: INNER
            	        {
            	        	Match(input,INNER,FOLLOW_INNER_in_joinOn1803); if (state.failed) return value;

            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:410:4: ( LEFT | RIGHT | FULL ) ( OUTER )?
            	        {
            	        	// MacroScope\\MacroScope.g:410:4: ( LEFT | RIGHT | FULL )
            	        	int alt47 = 3;
            	        	switch ( input.LA(1) ) 
            	        	{
            	        	case LEFT:
            	        		{
            	        	    alt47 = 1;
            	        	    }
            	        	    break;
            	        	case RIGHT:
            	        		{
            	        	    alt47 = 2;
            	        	    }
            	        	    break;
            	        	case FULL:
            	        		{
            	        	    alt47 = 3;
            	        	    }
            	        	    break;
            	        		default:
            	        		    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	        		    NoViableAltException nvae_d47s0 =
            	        		        new NoViableAltException("", 47, 0, input);

            	        		    throw nvae_d47s0;
            	        	}

            	        	switch (alt47) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:410:6: LEFT
            	        	        {
            	        	        	Match(input,LEFT,FOLLOW_LEFT_in_joinOn1810); if (state.failed) return value;
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   value =  Join.Left; 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // MacroScope\\MacroScope.g:411:5: RIGHT
            	        	        {
            	        	        	Match(input,RIGHT,FOLLOW_RIGHT_in_joinOn1818); if (state.failed) return value;
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   value =  Join.Right; 
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 3 :
            	        	        // MacroScope\\MacroScope.g:412:5: FULL
            	        	        {
            	        	        	Match(input,FULL,FOLLOW_FULL_in_joinOn1826); if (state.failed) return value;
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   value =  Join.Full; 
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	// MacroScope\\MacroScope.g:413:3: ( OUTER )?
            	        	int alt48 = 2;
            	        	int LA48_0 = input.LA(1);

            	        	if ( (LA48_0 == OUTER) )
            	        	{
            	        	    alt48 = 1;
            	        	}
            	        	switch (alt48) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:413:5: OUTER
            	        	        {
            	        	        	Match(input,OUTER,FOLLOW_OUTER_in_joinOn1836); if (state.failed) return value;

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	Match(input,JOIN,FOLLOW_JOIN_in_joinOn1846); if (state.failed) return value;

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "joinOn"


    // $ANTLR start "joinedTable"
    // MacroScope\\MacroScope.g:417:1: joinedTable returns [ Table value ] : ( CROSS JOIN t= subTableSource | (j= joinOn t= tableSource ON c= searchCondition ) );
    public Table joinedTable() // throws RecognitionException [1]
    {   
        Table value = default(Table);

        Table t = default(Table);

        Join j = default(Join);

        IExpression c = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:417:37: ( CROSS JOIN t= subTableSource | (j= joinOn t= tableSource ON c= searchCondition ) )
            int alt50 = 2;
            int LA50_0 = input.LA(1);

            if ( (LA50_0 == CROSS) )
            {
                alt50 = 1;
            }
            else if ( ((LA50_0 >= INNER && LA50_0 <= FULL) || LA50_0 == JOIN) )
            {
                alt50 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d50s0 =
                    new NoViableAltException("", 50, 0, input);

                throw nvae_d50s0;
            }
            switch (alt50) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:418:2: CROSS JOIN t= subTableSource
                    {
                    	Match(input,CROSS,FOLLOW_CROSS_in_joinedTable1861); if (state.failed) return value;
                    	Match(input,JOIN,FOLLOW_JOIN_in_joinedTable1863); if (state.failed) return value;
                    	PushFollow(FOLLOW_subTableSource_in_joinedTable1869);
                    	t = subTableSource();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  t;
                    	  		value.JoinType = Join.Cross;
                    	  	
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:422:4: (j= joinOn t= tableSource ON c= searchCondition )
                    {
                    	// MacroScope\\MacroScope.g:422:4: (j= joinOn t= tableSource ON c= searchCondition )
                    	// MacroScope\\MacroScope.g:423:3: j= joinOn t= tableSource ON c= searchCondition
                    	{
                    		PushFollow(FOLLOW_joinOn_in_joinedTable1884);
                    		j = joinOn();
                    		state.followingStackPointer--;
                    		if (state.failed) return value;
                    		PushFollow(FOLLOW_tableSource_in_joinedTable1893);
                    		t = tableSource();
                    		state.followingStackPointer--;
                    		if (state.failed) return value;
                    		if ( (state.backtracking==0) )
                    		{

                    		  				value =  t;
                    		  				value.JoinType = (j == null) ?
                    		  					Join.Inner :
                    		  					j;
                    		  			
                    		}
                    		Match(input,ON,FOLLOW_ON_in_joinedTable1900); if (state.failed) return value;
                    		PushFollow(FOLLOW_searchCondition_in_joinedTable1906);
                    		c = searchCondition();
                    		state.followingStackPointer--;
                    		if (state.failed) return value;
                    		if ( (state.backtracking==0) )
                    		{

                    		  				value.JoinCondition = c;
                    		  			
                    		}

                    	}


                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "joinedTable"


    // $ANTLR start "joinedTables"
    // MacroScope\\MacroScope.g:436:1: joinedTables returns [ Table value ] : t= subTableSource (t= joinedTable )+ ;
    public Table joinedTables() // throws RecognitionException [1]
    {   
        Table value = default(Table);

        Table t = default(Table);


        try 
    	{
            // MacroScope\\MacroScope.g:436:38: (t= subTableSource (t= joinedTable )+ )
            // MacroScope\\MacroScope.g:437:2: t= subTableSource (t= joinedTable )+
            {
            	PushFollow(FOLLOW_subTableSource_in_joinedTables1931);
            	t = subTableSource();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  t; 
            	}
            	// MacroScope\\MacroScope.g:438:3: (t= joinedTable )+
            	int cnt51 = 0;
            	do 
            	{
            	    int alt51 = 2;
            	    int LA51_0 = input.LA(1);

            	    if ( ((LA51_0 >= INNER && LA51_0 <= FULL) || (LA51_0 >= JOIN && LA51_0 <= CROSS)) )
            	    {
            	        alt51 = 1;
            	    }


            	    switch (alt51) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:438:5: t= joinedTable
            			    {
            			    	PushFollow(FOLLOW_joinedTable_in_joinedTables1943);
            			    	t = joinedTable();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   value.Add(t); 
            			    	}

            			    }
            			    break;

            			default:
            			    if ( cnt51 >= 1 ) goto loop51;
            			    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            		            EarlyExitException eee51 =
            		                new EarlyExitException(51, input);
            		            throw eee51;
            	    }
            	    cnt51++;
            	} while (true);

            	loop51:
            		;	// Stops C# compiler whinging that label 'loop51' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "joinedTables"


    // $ANTLR start "alias1"
    // MacroScope\\MacroScope.g:443:1: alias1 returns [ Identifier value ] : ( AS )? i= identifier ;
    public Identifier alias1() // throws RecognitionException [1]
    {   
        Identifier value = default(Identifier);

        Identifier i = default(Identifier);


        try 
    	{
            // MacroScope\\MacroScope.g:443:37: ( ( AS )? i= identifier )
            // MacroScope\\MacroScope.g:444:2: ( AS )? i= identifier
            {
            	// MacroScope\\MacroScope.g:444:2: ( AS )?
            	int alt52 = 2;
            	int LA52_0 = input.LA(1);

            	if ( (LA52_0 == AS) )
            	{
            	    alt52 = 1;
            	}
            	switch (alt52) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:444:3: AS
            	        {
            	        	Match(input,AS,FOLLOW_AS_in_alias11966); if (state.failed) return value;

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_identifier_in_alias11974);
            	i = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  i; 
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "alias1"


    // $ANTLR start "alias2"
    // MacroScope\\MacroScope.g:447:1: alias2 returns [ Identifier value ] : i= identifier ASSIGNEQUAL ;
    public Identifier alias2() // throws RecognitionException [1]
    {   
        Identifier value = default(Identifier);

        Identifier i = default(Identifier);


        try 
    	{
            // MacroScope\\MacroScope.g:447:37: (i= identifier ASSIGNEQUAL )
            // MacroScope\\MacroScope.g:448:2: i= identifier ASSIGNEQUAL
            {
            	PushFollow(FOLLOW_identifier_in_alias21995);
            	i = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  i; 
            	}
            	Match(input,ASSIGNEQUAL,FOLLOW_ASSIGNEQUAL_in_alias22001); if (state.failed) return value;

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "alias2"


    // $ANTLR start "tableColumns"
    // MacroScope\\MacroScope.g:452:1: tableColumns returns [ TableWildcard value ] : o= dbObject DOT_STAR ;
    public TableWildcard tableColumns() // throws RecognitionException [1]
    {   
        TableWildcard value = default(TableWildcard);

        DbObject o = default(DbObject);


        try 
    	{
            // MacroScope\\MacroScope.g:452:46: (o= dbObject DOT_STAR )
            // MacroScope\\MacroScope.g:453:2: o= dbObject DOT_STAR
            {
            	PushFollow(FOLLOW_dbObject_in_tableColumns2020);
            	o = dbObject();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	Match(input,DOT_STAR,FOLLOW_DOT_STAR_in_tableColumns2022); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new TableWildcard(o); 
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "tableColumns"


    // $ANTLR start "column"
    // MacroScope\\MacroScope.g:457:1: column returns [ DbObject value ] : (o= dbObject | LPAREN o= column RPAREN );
    public DbObject column() // throws RecognitionException [1]
    {   
        DbObject value = default(DbObject);

        DbObject o = default(DbObject);


        try 
    	{
            // MacroScope\\MacroScope.g:457:35: (o= dbObject | LPAREN o= column RPAREN )
            int alt53 = 2;
            int LA53_0 = input.LA(1);

            if ( (LA53_0 == NonQuotedIdentifier || LA53_0 == QuotedIdentifier) )
            {
                alt53 = 1;
            }
            else if ( (LA53_0 == LPAREN) )
            {
                alt53 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d53s0 =
                    new NoViableAltException("", 53, 0, input);

                throw nvae_d53s0;
            }
            switch (alt53) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:458:2: o= dbObject
                    {
                    	PushFollow(FOLLOW_dbObject_in_column2044);
                    	o = dbObject();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  o; 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:460:4: LPAREN o= column RPAREN
                    {
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_column2053); if (state.failed) return value;
                    	PushFollow(FOLLOW_column_in_column2059);
                    	o = column();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	Match(input,RPAREN,FOLLOW_RPAREN_in_column2061); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  o; 
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "column"


    // $ANTLR start "expression"
    // MacroScope\\MacroScope.g:463:1: expression returns [ IExpression value ] : e= additiveSubExpression (o= additiveOperator r= additiveSubExpression )* ;
    public IExpression expression() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        IExpression e = default(IExpression);

        ExpressionOperator o = default(ExpressionOperator);

        IExpression r = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:463:42: (e= additiveSubExpression (o= additiveOperator r= additiveSubExpression )* )
            // MacroScope\\MacroScope.g:464:2: e= additiveSubExpression (o= additiveOperator r= additiveSubExpression )*
            {
            	PushFollow(FOLLOW_additiveSubExpression_in_expression2082);
            	e = additiveSubExpression();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  e; 
            	}
            	// MacroScope\\MacroScope.g:465:2: (o= additiveOperator r= additiveSubExpression )*
            	do 
            	{
            	    int alt54 = 2;
            	    int LA54_0 = input.LA(1);

            	    if ( ((LA54_0 >= PLUS && LA54_0 <= STRCONCAT)) )
            	    {
            	        alt54 = 1;
            	    }


            	    switch (alt54) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:465:4: o= additiveOperator r= additiveSubExpression
            			    {
            			    	PushFollow(FOLLOW_additiveOperator_in_expression2093);
            			    	o = additiveOperator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	PushFollow(FOLLOW_additiveSubExpression_in_expression2099);
            			    	r = additiveSubExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  		value =  new Expression(value, o,
            			    	  			r);
            			    	  	
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop54;
            	    }
            	} while (true);

            	loop54:
            		;	// Stops C# compiler whining that label 'loop54' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "expression"


    // $ANTLR start "additiveSubExpression"
    // MacroScope\\MacroScope.g:471:1: additiveSubExpression returns [ IExpression value ] : e= subExpression (o= multiplicativeArithmeticOperator r= subExpression )* ;
    public IExpression additiveSubExpression() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        IExpression e = default(IExpression);

        ExpressionOperator o = default(ExpressionOperator);

        IExpression r = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:471:53: (e= subExpression (o= multiplicativeArithmeticOperator r= subExpression )* )
            // MacroScope\\MacroScope.g:472:2: e= subExpression (o= multiplicativeArithmeticOperator r= subExpression )*
            {
            	PushFollow(FOLLOW_subExpression_in_additiveSubExpression2124);
            	e = subExpression();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  e; 
            	}
            	// MacroScope\\MacroScope.g:473:2: (o= multiplicativeArithmeticOperator r= subExpression )*
            	do 
            	{
            	    int alt55 = 2;
            	    int LA55_0 = input.LA(1);

            	    if ( (LA55_0 == STAR || (LA55_0 >= DIVIDE && LA55_0 <= MOD)) )
            	    {
            	        alt55 = 1;
            	    }


            	    switch (alt55) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:473:4: o= multiplicativeArithmeticOperator r= subExpression
            			    {
            			    	PushFollow(FOLLOW_multiplicativeArithmeticOperator_in_additiveSubExpression2135);
            			    	o = multiplicativeArithmeticOperator();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	PushFollow(FOLLOW_subExpression_in_additiveSubExpression2141);
            			    	r = subExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  		value =  new Expression(value, o,
            			    	  			r);
            			    	  	
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop55;
            	    }
            	} while (true);

            	loop55:
            		;	// Stops C# compiler whining that label 'loop55' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "additiveSubExpression"


    // $ANTLR start "bracketedTerm"
    // MacroScope\\MacroScope.g:479:1: bracketedTerm returns [ IExpression value ] : LPAREN ( ( selectStatement )=>s= selectStatement RPAREN | e= expression RPAREN ) ;
    public IExpression bracketedTerm() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        SelectStatement s = default(SelectStatement);

        IExpression e = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:479:45: ( LPAREN ( ( selectStatement )=>s= selectStatement RPAREN | e= expression RPAREN ) )
            // MacroScope\\MacroScope.g:480:2: LPAREN ( ( selectStatement )=>s= selectStatement RPAREN | e= expression RPAREN )
            {
            	Match(input,LPAREN,FOLLOW_LPAREN_in_bracketedTerm2161); if (state.failed) return value;
            	// MacroScope\\MacroScope.g:480:9: ( ( selectStatement )=>s= selectStatement RPAREN | e= expression RPAREN )
            	int alt56 = 2;
            	alt56 = dfa56.Predict(input);
            	switch (alt56) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:480:11: ( selectStatement )=>s= selectStatement RPAREN
            	        {
            	        	PushFollow(FOLLOW_selectStatement_in_bracketedTerm2179);
            	        	s = selectStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	Match(input,RPAREN,FOLLOW_RPAREN_in_bracketedTerm2181); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  				value =  new BracketedExpression(s);
            	        	  				((BracketedExpression)value).Spaced = true;
            	        	  			
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:485:5: e= expression RPAREN
            	        {
            	        	PushFollow(FOLLOW_expression_in_bracketedTerm2193);
            	        	e = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	Match(input,RPAREN,FOLLOW_RPAREN_in_bracketedTerm2195); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			value =  e;
            	        	  		
            	        	}

            	        }
            	        break;

            	}


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "bracketedTerm"


    // $ANTLR start "subExpression"
    // MacroScope\\MacroScope.g:490:1: subExpression returns [ IExpression value ] : (o= unaryOperator )? (c= constant | v= variableReference | PLACEHOLDER | ( function )=>f= function | e= bracketedTerm | d= dbObject | p= caseFunction | q= castFunction ) ;
    public IExpression subExpression() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        ExpressionOperator o = default(ExpressionOperator);

        INode c = default(INode);

        Variable v = default(Variable);

        IExpression f = default(IExpression);

        IExpression e = default(IExpression);

        DbObject d = default(DbObject);

        CaseExpression p = default(CaseExpression);

        TypeCast q = default(TypeCast);


        try 
    	{
            // MacroScope\\MacroScope.g:490:45: ( (o= unaryOperator )? (c= constant | v= variableReference | PLACEHOLDER | ( function )=>f= function | e= bracketedTerm | d= dbObject | p= caseFunction | q= castFunction ) )
            // MacroScope\\MacroScope.g:491:2: (o= unaryOperator )? (c= constant | v= variableReference | PLACEHOLDER | ( function )=>f= function | e= bracketedTerm | d= dbObject | p= caseFunction | q= castFunction )
            {
            	// MacroScope\\MacroScope.g:491:2: (o= unaryOperator )?
            	int alt57 = 2;
            	int LA57_0 = input.LA(1);

            	if ( ((LA57_0 >= PLUS && LA57_0 <= MINUS)) )
            	{
            	    alt57 = 1;
            	}
            	switch (alt57) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:491:4: o= unaryOperator
            	        {
            	        	PushFollow(FOLLOW_unaryOperator_in_subExpression2220);
            	        	o = unaryOperator();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  		value =  new Expression();
            	        	  		((Expression)value).Operator = o;
            	        	  	
            	        	}

            	        }
            	        break;

            	}

            	// MacroScope\\MacroScope.g:494:7: (c= constant | v= variableReference | PLACEHOLDER | ( function )=>f= function | e= bracketedTerm | d= dbObject | p= caseFunction | q= castFunction )
            	int alt58 = 8;
            	alt58 = dfa58.Predict(input);
            	switch (alt58) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:495:3: c= constant
            	        {
            	        	PushFollow(FOLLOW_constant_in_subExpression2235);
            	        	c = constant();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			if (value == null)
            	        	  			{
            	        	  				value =  new Expression();
            	        	  			}

            	        	  			((Expression)value).Right = c;
            	        	  		
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:503:5: v= variableReference
            	        {
            	        	PushFollow(FOLLOW_variableReference_in_subExpression2247);
            	        	v = variableReference();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			if (value == null)
            	        	  			{
            	        	  				value =  new Expression();
            	        	  			}

            	        	  			((Expression)value).Right = v;
            	        	  		
            	        	}

            	        }
            	        break;
            	    case 3 :
            	        // MacroScope\\MacroScope.g:511:5: PLACEHOLDER
            	        {
            	        	Match(input,PLACEHOLDER,FOLLOW_PLACEHOLDER_in_subExpression2255); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			if (value == null)
            	        	  			{
            	        	  				value =  new Expression();
            	        	  			}

            	        	  			((Expression)value).Right = Placeholder.Value;
            	        	  		
            	        	}

            	        }
            	        break;
            	    case 4 :
            	        // MacroScope\\MacroScope.g:519:5: ( function )=>f= function
            	        {
            	        	PushFollow(FOLLOW_function_in_subExpression2276);
            	        	f = function();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  				if (value == null)
            	        	  				{
            	        	  					// Oracle tailor wanting to replace
            	        	  					// a datetime function will
            	        	  					// appreciate an Expression parent
            	        	  					value =  new Expression();
            	        	  				}

            	        	  				((Expression)value).Right = f;
            	        	  			
            	        	}

            	        }
            	        break;
            	    case 5 :
            	        // MacroScope\\MacroScope.g:531:5: e= bracketedTerm
            	        {
            	        	PushFollow(FOLLOW_bracketedTerm_in_subExpression2288);
            	        	e = bracketedTerm();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			if (value == null)
            	        	  			{
            	        	  				value =  e;
            	        	  			}
            	        	  			else
            	        	  			{
            	        	  				((Expression)value).Right = e;
            	        	  			}
            	        	  		
            	        	}

            	        }
            	        break;
            	    case 6 :
            	        // MacroScope\\MacroScope.g:541:5: d= dbObject
            	        {
            	        	PushFollow(FOLLOW_dbObject_in_subExpression2300);
            	        	d = dbObject();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			if (value == null)
            	        	  			{
            	        	  				value =  new Expression();
            	        	  			}

            	        	  			((Expression)value).Right = d;
            	        	  		
            	        	}

            	        }
            	        break;
            	    case 7 :
            	        // MacroScope\\MacroScope.g:551:5: p= caseFunction
            	        {
            	        	PushFollow(FOLLOW_caseFunction_in_subExpression2346);
            	        	p = caseFunction();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  				if (value == null)
            	        	  				{
            	        	  					// tailors wanting to replace this
            	        	  					// object will appreciate
            	        	  					// an Expression parent
            	        	  					value =  new Expression();
            	        	  				}

            	        	  				((Expression)value).Right = p;
            	        	  			
            	        	}

            	        }
            	        break;
            	    case 8 :
            	        // MacroScope\\MacroScope.g:562:5: q= castFunction
            	        {
            	        	PushFollow(FOLLOW_castFunction_in_subExpression2358);
            	        	q = castFunction();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  				if (value == null)
            	        	  				{
            	        	  					value =  q;
            	        	  				}
            	        	  				else
            	        	  				{
            	        	  					((Expression)value).Right = q;
            	        	  				}
            	        	  			
            	        	}

            	        }
            	        break;

            	}


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "subExpression"


    // $ANTLR start "variableReference"
    // MacroScope\\MacroScope.g:575:1: variableReference returns [ Variable value ] : Variable ;
    public Variable variableReference() // throws RecognitionException [1]
    {   
        Variable value = default(Variable);

        IToken Variable2 = null;

        try 
    	{
            // MacroScope\\MacroScope.g:575:46: ( Variable )
            // MacroScope\\MacroScope.g:576:2: Variable
            {
            	Variable2=(IToken)Match(input,Variable,FOLLOW_Variable_in_variableReference2377); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new Variable(((Variable2 != null) ? Variable2.Text : null)); 
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "variableReference"


    // $ANTLR start "function"
    // MacroScope\\MacroScope.g:580:1: function returns [ IExpression value ] : ( SUBSTRING LPAREN v= expression FROM s= expression ( FOR l= expression )? RPAREN | EXTRACT LPAREN d= datetimeField FROM s= expression RPAREN | f= genericFunction );
    public IExpression function() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        IExpression v = default(IExpression);

        IExpression s = default(IExpression);

        IExpression l = default(IExpression);

        DateTimeUnit d = default(DateTimeUnit);

        FunctionCall f = default(FunctionCall);


        try 
    	{
            // MacroScope\\MacroScope.g:580:40: ( SUBSTRING LPAREN v= expression FROM s= expression ( FOR l= expression )? RPAREN | EXTRACT LPAREN d= datetimeField FROM s= expression RPAREN | f= genericFunction )
            int alt60 = 3;
            switch ( input.LA(1) ) 
            {
            case SUBSTRING:
            	{
                alt60 = 1;
                }
                break;
            case EXTRACT:
            	{
                alt60 = 2;
                }
                break;
            case LEFT:
            case RIGHT:
            case NonQuotedIdentifier:
            	{
                alt60 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	    NoViableAltException nvae_d60s0 =
            	        new NoViableAltException("", 60, 0, input);

            	    throw nvae_d60s0;
            }

            switch (alt60) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:581:2: SUBSTRING LPAREN v= expression FROM s= expression ( FOR l= expression )? RPAREN
                    {
                    	Match(input,SUBSTRING,FOLLOW_SUBSTRING_in_function2395); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new FunctionCall(TailorUtil.SUBSTRING);
                    	  	
                    	}
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_function2399); if (state.failed) return value;
                    	PushFollow(FOLLOW_expression_in_function2405);
                    	v = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	   			((FunctionCall)value).ExpressionArguments =
                    	  				new ExpressionItem(v);
                    	  		
                    	}
                    	Match(input,FROM,FOLLOW_FROM_in_function2409); if (state.failed) return value;
                    	PushFollow(FOLLOW_expression_in_function2415);
                    	s = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			((FunctionCall)value).ExpressionArguments.Add(
                    	  				new ExpressionItem(s));
                    	  		
                    	}
                    	// MacroScope\\MacroScope.g:589:5: ( FOR l= expression )?
                    	int alt59 = 2;
                    	int LA59_0 = input.LA(1);

                    	if ( (LA59_0 == FOR) )
                    	{
                    	    alt59 = 1;
                    	}
                    	switch (alt59) 
                    	{
                    	    case 1 :
                    	        // MacroScope\\MacroScope.g:589:7: FOR l= expression
                    	        {
                    	        	Match(input,FOR,FOLLOW_FOR_in_function2421); if (state.failed) return value;
                    	        	PushFollow(FOLLOW_expression_in_function2427);
                    	        	l = expression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return value;
                    	        	if ( (state.backtracking==0) )
                    	        	{

                    	        	  				((FunctionCall)value).ExpressionArguments.Add(new ExpressionItem(l));
                    	        	  			
                    	        	}

                    	        }
                    	        break;

                    	}

                    	Match(input,RPAREN,FOLLOW_RPAREN_in_function2434); if (state.failed) return value;

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:592:4: EXTRACT LPAREN d= datetimeField FROM s= expression RPAREN
                    {
                    	Match(input,EXTRACT,FOLLOW_EXTRACT_in_function2439); if (state.failed) return value;
                    	Match(input,LPAREN,FOLLOW_LPAREN_in_function2441); if (state.failed) return value;
                    	PushFollow(FOLLOW_datetimeField_in_function2447);
                    	d = datetimeField();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	Match(input,FROM,FOLLOW_FROM_in_function2449); if (state.failed) return value;
                    	PushFollow(FOLLOW_expression_in_function2455);
                    	s = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  			value =  new ExtractFunction(d, s);
                    	  		
                    	}
                    	Match(input,RPAREN,FOLLOW_RPAREN_in_function2459); if (state.failed) return value;

                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:595:4: f= genericFunction
                    {
                    	PushFollow(FOLLOW_genericFunction_in_function2468);
                    	f = genericFunction();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  f;
                    	  	
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "function"


    // $ANTLR start "genericFunction"
    // MacroScope\\MacroScope.g:600:1: genericFunction returns [ FunctionCall value ] : ( NonQuotedIdentifier | LEFT | RIGHT ) LPAREN (e= functionArgument ( COMMA e= functionArgument )* | STAR | ( ALL | DISTINCT ) ( STAR | e= expression ) )? RPAREN ;
    public FunctionCall genericFunction() // throws RecognitionException [1]
    {   
        FunctionCall value = default(FunctionCall);

        IToken NonQuotedIdentifier3 = null;
        IExpression e = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:600:48: ( ( NonQuotedIdentifier | LEFT | RIGHT ) LPAREN (e= functionArgument ( COMMA e= functionArgument )* | STAR | ( ALL | DISTINCT ) ( STAR | e= expression ) )? RPAREN )
            // MacroScope\\MacroScope.g:602:2: ( NonQuotedIdentifier | LEFT | RIGHT ) LPAREN (e= functionArgument ( COMMA e= functionArgument )* | STAR | ( ALL | DISTINCT ) ( STAR | e= expression ) )? RPAREN
            {
            	// MacroScope\\MacroScope.g:602:2: ( NonQuotedIdentifier | LEFT | RIGHT )
            	int alt61 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case NonQuotedIdentifier:
            		{
            	    alt61 = 1;
            	    }
            	    break;
            	case LEFT:
            		{
            	    alt61 = 2;
            	    }
            	    break;
            	case RIGHT:
            		{
            	    alt61 = 3;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            		    NoViableAltException nvae_d61s0 =
            		        new NoViableAltException("", 61, 0, input);

            		    throw nvae_d61s0;
            	}

            	switch (alt61) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:605:3: NonQuotedIdentifier
            	        {
            	        	NonQuotedIdentifier3=(IToken)Match(input,NonQuotedIdentifier,FOLLOW_NonQuotedIdentifier_in_genericFunction2497); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			value =  new FunctionCall(((NonQuotedIdentifier3 != null) ? NonQuotedIdentifier3.Text : null));
            	        	  		
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:608:5: LEFT
            	        {
            	        	Match(input,LEFT,FOLLOW_LEFT_in_genericFunction2505); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			value =  new FunctionCall(
            	        	  				TailorUtil.LEFT.ToUpperInvariant());
            	        	  		
            	        	}

            	        }
            	        break;
            	    case 3 :
            	        // MacroScope\\MacroScope.g:612:5: RIGHT
            	        {
            	        	Match(input,RIGHT,FOLLOW_RIGHT_in_genericFunction2513); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			value =  new FunctionCall(
            	        	  				TailorUtil.RIGHT.ToUpperInvariant());
            	        	  		
            	        	}

            	        }
            	        break;

            	}

            	Match(input,LPAREN,FOLLOW_LPAREN_in_genericFunction2520); if (state.failed) return value;
            	// MacroScope\\MacroScope.g:616:11: (e= functionArgument ( COMMA e= functionArgument )* | STAR | ( ALL | DISTINCT ) ( STAR | e= expression ) )?
            	int alt65 = 4;
            	switch ( input.LA(1) ) 
            	{
            	    case LPAREN:
            	    case Integer:
            	    case NULL:
            	    case LEFT:
            	    case RIGHT:
            	    case PLACEHOLDER:
            	    case Variable:
            	    case SUBSTRING:
            	    case EXTRACT:
            	    case NonQuotedIdentifier:
            	    case CASE:
            	    case CAST:
            	    case UnicodeStringLiteral:
            	    case AsciiStringLiteral:
            	    case QuotedIdentifier:
            	    case Real:
            	    case HexLiteral:
            	    case MAccessDateTime:
            	    case Iso8601DateTime:
            	    case TIMESTAMP:
            	    case INTERVAL:
            	    case PLUS:
            	    case MINUS:
            	    case YEAR:
            	    case MONTH:
            	    case DAY:
            	    case HOUR:
            	    case MINUTE:
            	    case SECOND:
            	    	{
            	        alt65 = 1;
            	        }
            	        break;
            	    case STAR:
            	    	{
            	        alt65 = 2;
            	        }
            	        break;
            	    case ALL:
            	    case DISTINCT:
            	    	{
            	        alt65 = 3;
            	        }
            	        break;
            	}

            	switch (alt65) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:617:3: e= functionArgument ( COMMA e= functionArgument )*
            	        {
            	        	PushFollow(FOLLOW_functionArgument_in_genericFunction2530);
            	        	e = functionArgument();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	   			value.ExpressionArguments =
            	        	  				new ExpressionItem(e);
            	        	  		
            	        	}
            	        	// MacroScope\\MacroScope.g:621:4: ( COMMA e= functionArgument )*
            	        	do 
            	        	{
            	        	    int alt62 = 2;
            	        	    int LA62_0 = input.LA(1);

            	        	    if ( (LA62_0 == COMMA) )
            	        	    {
            	        	        alt62 = 1;
            	        	    }


            	        	    switch (alt62) 
            	        		{
            	        			case 1 :
            	        			    // MacroScope\\MacroScope.g:621:6: COMMA e= functionArgument
            	        			    {
            	        			    	Match(input,COMMA,FOLLOW_COMMA_in_genericFunction2539); if (state.failed) return value;
            	        			    	PushFollow(FOLLOW_functionArgument_in_genericFunction2545);
            	        			    	e = functionArgument();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return value;
            	        			    	if ( (state.backtracking==0) )
            	        			    	{

            	        			    	  				value.ExpressionArguments.Add(
            	        			    	  					new ExpressionItem(e));
            	        			    	  			
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop62;
            	        	    }
            	        	} while (true);

            	        	loop62:
            	        		;	// Stops C# compiler whining that label 'loop62' has no statements


            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:627:5: STAR
            	        {
            	        	Match(input,STAR,FOLLOW_STAR_in_genericFunction2562); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.Star = Wildcard.Value; 
            	        	}

            	        }
            	        break;
            	    case 3 :
            	        // MacroScope\\MacroScope.g:628:12: ( ALL | DISTINCT ) ( STAR | e= expression )
            	        {
            	        	// MacroScope\\MacroScope.g:628:12: ( ALL | DISTINCT )
            	        	int alt63 = 2;
            	        	int LA63_0 = input.LA(1);

            	        	if ( (LA63_0 == ALL) )
            	        	{
            	        	    alt63 = 1;
            	        	}
            	        	else if ( (LA63_0 == DISTINCT) )
            	        	{
            	        	    alt63 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	        	    NoViableAltException nvae_d63s0 =
            	        	        new NoViableAltException("", 63, 0, input);

            	        	    throw nvae_d63s0;
            	        	}
            	        	switch (alt63) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:628:13: ALL
            	        	        {
            	        	        	Match(input,ALL,FOLLOW_ALL_in_genericFunction2578); if (state.failed) return value;

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // MacroScope\\MacroScope.g:628:19: DISTINCT
            	        	        {
            	        	        	Match(input,DISTINCT,FOLLOW_DISTINCT_in_genericFunction2582); if (state.failed) return value;
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   value.Distinct = true; 
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	// MacroScope\\MacroScope.g:628:58: ( STAR | e= expression )
            	        	int alt64 = 2;
            	        	int LA64_0 = input.LA(1);

            	        	if ( (LA64_0 == STAR) )
            	        	{
            	        	    alt64 = 1;
            	        	}
            	        	else if ( (LA64_0 == LPAREN || LA64_0 == Integer || LA64_0 == NULL || (LA64_0 >= LEFT && LA64_0 <= RIGHT) || (LA64_0 >= PLACEHOLDER && LA64_0 <= SUBSTRING) || (LA64_0 >= EXTRACT && LA64_0 <= CASE) || LA64_0 == CAST || (LA64_0 >= UnicodeStringLiteral && LA64_0 <= MINUS)) )
            	        	{
            	        	    alt64 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	        	    NoViableAltException nvae_d64s0 =
            	        	        new NoViableAltException("", 64, 0, input);

            	        	    throw nvae_d64s0;
            	        	}
            	        	switch (alt64) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:629:4: STAR
            	        	        {
            	        	        	Match(input,STAR,FOLLOW_STAR_in_genericFunction2593); if (state.failed) return value;
            	        	        	if ( (state.backtracking==0) )
            	        	        	{
            	        	        	   value.Star = Wildcard.Value;
            	        	        	  			
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // MacroScope\\MacroScope.g:632:6: e= expression
            	        	        {
            	        	        	PushFollow(FOLLOW_expression_in_genericFunction2610);
            	        	        	e = expression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return value;
            	        	        	if ( (state.backtracking==0) )
            	        	        	{

            	        	        	  	 			value.ExpressionArguments =
            	        	        	  					new ExpressionItem(e);
            	        	        	  			
            	        	        	}

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	Match(input,RPAREN,FOLLOW_RPAREN_in_genericFunction2632); if (state.failed) return value;

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "genericFunction"


    // $ANTLR start "functionArgument"
    // MacroScope\\MacroScope.g:641:1: functionArgument returns [ IExpression value ] : (e= expression | d= datetimeField );
    public IExpression functionArgument() // throws RecognitionException [1]
    {   
        IExpression value = default(IExpression);

        IExpression e = default(IExpression);

        DateTimeUnit d = default(DateTimeUnit);


        try 
    	{
            // MacroScope\\MacroScope.g:641:48: (e= expression | d= datetimeField )
            int alt66 = 2;
            int LA66_0 = input.LA(1);

            if ( (LA66_0 == LPAREN || LA66_0 == Integer || LA66_0 == NULL || (LA66_0 >= LEFT && LA66_0 <= RIGHT) || (LA66_0 >= PLACEHOLDER && LA66_0 <= SUBSTRING) || (LA66_0 >= EXTRACT && LA66_0 <= CASE) || LA66_0 == CAST || (LA66_0 >= UnicodeStringLiteral && LA66_0 <= MINUS)) )
            {
                alt66 = 1;
            }
            else if ( ((LA66_0 >= YEAR && LA66_0 <= SECOND)) )
            {
                alt66 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d66s0 =
                    new NoViableAltException("", 66, 0, input);

                throw nvae_d66s0;
            }
            switch (alt66) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:642:2: e= expression
                    {
                    	PushFollow(FOLLOW_expression_in_functionArgument2651);
                    	e = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  e;
                    	  	
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:645:4: d= datetimeField
                    {
                    	PushFollow(FOLLOW_datetimeField_in_functionArgument2662);
                    	d = datetimeField();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new Expression();
                    	  		((Expression)value).Left = d;
                    	  	
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "functionArgument"


    // $ANTLR start "caseFunction"
    // MacroScope\\MacroScope.g:651:1: caseFunction returns [ CaseExpression value ] : CASE (e= expression ( WHEN e= expression THEN f= expression )+ | ( WHEN e= searchCondition THEN f= expression )+ ) ( ELSE e= expression )? END ( CASE )? ;
    public CaseExpression caseFunction() // throws RecognitionException [1]
    {   
        CaseExpression value = default(CaseExpression);

        IExpression e = default(IExpression);

        IExpression f = default(IExpression);


        try 
    	{
            // MacroScope\\MacroScope.g:651:47: ( CASE (e= expression ( WHEN e= expression THEN f= expression )+ | ( WHEN e= searchCondition THEN f= expression )+ ) ( ELSE e= expression )? END ( CASE )? )
            // MacroScope\\MacroScope.g:652:2: CASE (e= expression ( WHEN e= expression THEN f= expression )+ | ( WHEN e= searchCondition THEN f= expression )+ ) ( ELSE e= expression )? END ( CASE )?
            {
            	Match(input,CASE,FOLLOW_CASE_in_caseFunction2679); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new CaseExpression(); 
            	}
            	// MacroScope\\MacroScope.g:652:42: (e= expression ( WHEN e= expression THEN f= expression )+ | ( WHEN e= searchCondition THEN f= expression )+ )
            	int alt69 = 2;
            	int LA69_0 = input.LA(1);

            	if ( (LA69_0 == LPAREN || LA69_0 == Integer || LA69_0 == NULL || (LA69_0 >= LEFT && LA69_0 <= RIGHT) || (LA69_0 >= PLACEHOLDER && LA69_0 <= SUBSTRING) || (LA69_0 >= EXTRACT && LA69_0 <= CASE) || LA69_0 == CAST || (LA69_0 >= UnicodeStringLiteral && LA69_0 <= MINUS)) )
            	{
            	    alt69 = 1;
            	}
            	else if ( (LA69_0 == WHEN) )
            	{
            	    alt69 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	    NoViableAltException nvae_d69s0 =
            	        new NoViableAltException("", 69, 0, input);

            	    throw nvae_d69s0;
            	}
            	switch (alt69) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:653:3: e= expression ( WHEN e= expression THEN f= expression )+
            	        {
            	        	PushFollow(FOLLOW_expression_in_caseFunction2691);
            	        	e = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value.Case = e; 
            	        	}
            	        	// MacroScope\\MacroScope.g:654:4: ( WHEN e= expression THEN f= expression )+
            	        	int cnt67 = 0;
            	        	do 
            	        	{
            	        	    int alt67 = 2;
            	        	    int LA67_0 = input.LA(1);

            	        	    if ( (LA67_0 == WHEN) )
            	        	    {
            	        	        alt67 = 1;
            	        	    }


            	        	    switch (alt67) 
            	        		{
            	        			case 1 :
            	        			    // MacroScope\\MacroScope.g:654:6: WHEN e= expression THEN f= expression
            	        			    {
            	        			    	Match(input,WHEN,FOLLOW_WHEN_in_caseFunction2700); if (state.failed) return value;
            	        			    	PushFollow(FOLLOW_expression_in_caseFunction2706);
            	        			    	e = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return value;
            	        			    	Match(input,THEN,FOLLOW_THEN_in_caseFunction2708); if (state.failed) return value;
            	        			    	PushFollow(FOLLOW_expression_in_caseFunction2714);
            	        			    	f = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return value;
            	        			    	if ( (state.backtracking==0) )
            	        			    	{

            	        			    	  				value.Add(new CaseAlternative(e,
            	        			    	  					f));
            	        			    	  			
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    if ( cnt67 >= 1 ) goto loop67;
            	        			    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	        		            EarlyExitException eee67 =
            	        		                new EarlyExitException(67, input);
            	        		            throw eee67;
            	        	    }
            	        	    cnt67++;
            	        	} while (true);

            	        	loop67:
            	        		;	// Stops C# compiler whinging that label 'loop67' has no statements


            	        }
            	        break;
            	    case 2 :
            	        // MacroScope\\MacroScope.g:659:11: ( WHEN e= searchCondition THEN f= expression )+
            	        {
            	        	// MacroScope\\MacroScope.g:659:11: ( WHEN e= searchCondition THEN f= expression )+
            	        	int cnt68 = 0;
            	        	do 
            	        	{
            	        	    int alt68 = 2;
            	        	    int LA68_0 = input.LA(1);

            	        	    if ( (LA68_0 == WHEN) )
            	        	    {
            	        	        alt68 = 1;
            	        	    }


            	        	    switch (alt68) 
            	        		{
            	        			case 1 :
            	        			    // MacroScope\\MacroScope.g:659:13: WHEN e= searchCondition THEN f= expression
            	        			    {
            	        			    	Match(input,WHEN,FOLLOW_WHEN_in_caseFunction2735); if (state.failed) return value;
            	        			    	PushFollow(FOLLOW_searchCondition_in_caseFunction2741);
            	        			    	e = searchCondition();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return value;
            	        			    	Match(input,THEN,FOLLOW_THEN_in_caseFunction2743); if (state.failed) return value;
            	        			    	PushFollow(FOLLOW_expression_in_caseFunction2749);
            	        			    	f = expression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return value;
            	        			    	if ( (state.backtracking==0) )
            	        			    	{

            	        			    	  			value.Add(new CaseAlternative(e,
            	        			    	  				f));
            	        			    	  		
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    if ( cnt68 >= 1 ) goto loop68;
            	        			    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	        		            EarlyExitException eee68 =
            	        		                new EarlyExitException(68, input);
            	        		            throw eee68;
            	        	    }
            	        	    cnt68++;
            	        	} while (true);

            	        	loop68:
            	        		;	// Stops C# compiler whinging that label 'loop68' has no statements


            	        }
            	        break;

            	}

            	// MacroScope\\MacroScope.g:664:3: ( ELSE e= expression )?
            	int alt70 = 2;
            	int LA70_0 = input.LA(1);

            	if ( (LA70_0 == ELSE) )
            	{
            	    alt70 = 1;
            	}
            	switch (alt70) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:664:5: ELSE e= expression
            	        {
            	        	Match(input,ELSE,FOLLOW_ELSE_in_caseFunction2770); if (state.failed) return value;
            	        	PushFollow(FOLLOW_expression_in_caseFunction2776);
            	        	e = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			value.Else = e;
            	        	  		
            	        	}

            	        }
            	        break;

            	}

            	Match(input,END,FOLLOW_END_in_caseFunction2783); if (state.failed) return value;
            	// MacroScope\\MacroScope.g:666:12: ( CASE )?
            	int alt71 = 2;
            	int LA71_0 = input.LA(1);

            	if ( (LA71_0 == CASE) )
            	{
            	    alt71 = 1;
            	}
            	switch (alt71) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:666:14: CASE
            	        {
            	        	Match(input,CASE,FOLLOW_CASE_in_caseFunction2787); if (state.failed) return value;

            	        }
            	        break;

            	}


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "caseFunction"


    // $ANTLR start "castFunction"
    // MacroScope\\MacroScope.g:669:1: castFunction returns [ TypeCast value ] : CAST LPAREN e= expression AS t= typeIdentifier ( LPAREN p= nonNegativeInteger ( COMMA p= nonNegativeInteger )? RPAREN )? RPAREN ;
    public TypeCast castFunction() // throws RecognitionException [1]
    {   
        TypeCast value = default(TypeCast);

        IExpression e = default(IExpression);

        string t = default(string);

        int p = default(int);


        try 
    	{
            // MacroScope\\MacroScope.g:669:41: ( CAST LPAREN e= expression AS t= typeIdentifier ( LPAREN p= nonNegativeInteger ( COMMA p= nonNegativeInteger )? RPAREN )? RPAREN )
            // MacroScope\\MacroScope.g:670:2: CAST LPAREN e= expression AS t= typeIdentifier ( LPAREN p= nonNegativeInteger ( COMMA p= nonNegativeInteger )? RPAREN )? RPAREN
            {
            	Match(input,CAST,FOLLOW_CAST_in_castFunction2806); if (state.failed) return value;
            	Match(input,LPAREN,FOLLOW_LPAREN_in_castFunction2808); if (state.failed) return value;
            	PushFollow(FOLLOW_expression_in_castFunction2814);
            	e = expression();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	Match(input,AS,FOLLOW_AS_in_castFunction2816); if (state.failed) return value;
            	PushFollow(FOLLOW_typeIdentifier_in_castFunction2822);
            	t = typeIdentifier();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  		value =  new TypeCast(e, t);
            	  	
            	}
            	// MacroScope\\MacroScope.g:673:3: ( LPAREN p= nonNegativeInteger ( COMMA p= nonNegativeInteger )? RPAREN )?
            	int alt73 = 2;
            	int LA73_0 = input.LA(1);

            	if ( (LA73_0 == LPAREN) )
            	{
            	    alt73 = 1;
            	}
            	switch (alt73) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:673:5: LPAREN p= nonNegativeInteger ( COMMA p= nonNegativeInteger )? RPAREN
            	        {
            	        	Match(input,LPAREN,FOLLOW_LPAREN_in_castFunction2830); if (state.failed) return value;
            	        	PushFollow(FOLLOW_nonNegativeInteger_in_castFunction2836);
            	        	p = nonNegativeInteger();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			value.Precision = p;
            	        	  		
            	        	}
            	        	// MacroScope\\MacroScope.g:675:5: ( COMMA p= nonNegativeInteger )?
            	        	int alt72 = 2;
            	        	int LA72_0 = input.LA(1);

            	        	if ( (LA72_0 == COMMA) )
            	        	{
            	        	    alt72 = 1;
            	        	}
            	        	switch (alt72) 
            	        	{
            	        	    case 1 :
            	        	        // MacroScope\\MacroScope.g:675:7: COMMA p= nonNegativeInteger
            	        	        {
            	        	        	Match(input,COMMA,FOLLOW_COMMA_in_castFunction2842); if (state.failed) return value;
            	        	        	PushFollow(FOLLOW_nonNegativeInteger_in_castFunction2848);
            	        	        	p = nonNegativeInteger();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return value;
            	        	        	if ( (state.backtracking==0) )
            	        	        	{

            	        	        	  				value.SecondPrecision = p;
            	        	        	  			
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	Match(input,RPAREN,FOLLOW_RPAREN_in_castFunction2855); if (state.failed) return value;

            	        }
            	        break;

            	}

            	Match(input,RPAREN,FOLLOW_RPAREN_in_castFunction2860); if (state.failed) return value;

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "castFunction"


    // $ANTLR start "dbObject"
    // MacroScope\\MacroScope.g:680:1: dbObject returns [ DbObject value ] : i= identifier ( DOT i= identifier )* ;
    public DbObject dbObject() // throws RecognitionException [1]
    {   
        DbObject value = default(DbObject);

        Identifier i = default(Identifier);


        try 
    	{
            // MacroScope\\MacroScope.g:680:37: (i= identifier ( DOT i= identifier )* )
            // MacroScope\\MacroScope.g:681:2: i= identifier ( DOT i= identifier )*
            {
            	PushFollow(FOLLOW_identifier_in_dbObject2879);
            	i = identifier();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  new DbObject(i); 
            	}
            	// MacroScope\\MacroScope.g:682:2: ( DOT i= identifier )*
            	do 
            	{
            	    int alt74 = 2;
            	    int LA74_0 = input.LA(1);

            	    if ( (LA74_0 == DOT) )
            	    {
            	        alt74 = 1;
            	    }


            	    switch (alt74) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:682:4: DOT i= identifier
            			    {
            			    	Match(input,DOT,FOLLOW_DOT_in_dbObject2886); if (state.failed) return value;
            			    	PushFollow(FOLLOW_identifier_in_dbObject2892);
            			    	i = identifier();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	   value.Add(new DbObject(i)); 
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop74;
            	    }
            	} while (true);

            	loop74:
            		;	// Stops C# compiler whining that label 'loop74' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "dbObject"


    // $ANTLR start "stringLiteral"
    // MacroScope\\MacroScope.g:688:1: stringLiteral returns [ StringValue value ] : s= singleStringLiteral (s= singleStringLiteral )* ;
    public StringValue stringLiteral() // throws RecognitionException [1]
    {   
        StringValue value = default(StringValue);

        StringValue s = default(StringValue);


        try 
    	{
            // MacroScope\\MacroScope.g:688:45: (s= singleStringLiteral (s= singleStringLiteral )* )
            // MacroScope\\MacroScope.g:689:2: s= singleStringLiteral (s= singleStringLiteral )*
            {
            	PushFollow(FOLLOW_singleStringLiteral_in_stringLiteral2920);
            	s = singleStringLiteral();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  		value =  s;
            	  	
            	}
            	// MacroScope\\MacroScope.g:691:4: (s= singleStringLiteral )*
            	do 
            	{
            	    int alt75 = 2;
            	    int LA75_0 = input.LA(1);

            	    if ( ((LA75_0 >= UnicodeStringLiteral && LA75_0 <= AsciiStringLiteral)) )
            	    {
            	        alt75 = 1;
            	    }


            	    switch (alt75) 
            		{
            			case 1 :
            			    // MacroScope\\MacroScope.g:691:6: s= singleStringLiteral
            			    {
            			    	PushFollow(FOLLOW_singleStringLiteral_in_stringLiteral2930);
            			    	s = singleStringLiteral();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{

            			    	  		value.Append(s);
            			    	  		
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop75;
            	    }
            	} while (true);

            	loop75:
            		;	// Stops C# compiler whining that label 'loop75' has no statements


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "stringLiteral"


    // $ANTLR start "singleStringLiteral"
    // MacroScope\\MacroScope.g:696:1: singleStringLiteral returns [ StringValue value ] : ( UnicodeStringLiteral | AsciiStringLiteral );
    public StringValue singleStringLiteral() // throws RecognitionException [1]
    {   
        StringValue value = default(StringValue);

        IToken UnicodeStringLiteral4 = null;
        IToken AsciiStringLiteral5 = null;

        try 
    	{
            // MacroScope\\MacroScope.g:696:51: ( UnicodeStringLiteral | AsciiStringLiteral )
            int alt76 = 2;
            int LA76_0 = input.LA(1);

            if ( (LA76_0 == UnicodeStringLiteral) )
            {
                alt76 = 1;
            }
            else if ( (LA76_0 == AsciiStringLiteral) )
            {
                alt76 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d76s0 =
                    new NoViableAltException("", 76, 0, input);

                throw nvae_d76s0;
            }
            switch (alt76) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:697:2: UnicodeStringLiteral
                    {
                    	UnicodeStringLiteral4=(IToken)Match(input,UnicodeStringLiteral,FOLLOW_UnicodeStringLiteral_in_singleStringLiteral2950); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new StringValue(((UnicodeStringLiteral4 != null) ? UnicodeStringLiteral4.Text : null));
                    	  		value.QuoteType = 'n';
                    	  	
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:701:4: AsciiStringLiteral
                    {
                    	AsciiStringLiteral5=(IToken)Match(input,AsciiStringLiteral,FOLLOW_AsciiStringLiteral_in_singleStringLiteral2957); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new StringValue(((AsciiStringLiteral5 != null) ? AsciiStringLiteral5.Text : null));
                    	  	
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "singleStringLiteral"


    // $ANTLR start "identifier"
    // MacroScope\\MacroScope.g:706:1: identifier returns [ Identifier value ] : ( NonQuotedIdentifier | QuotedIdentifier );
    public Identifier identifier() // throws RecognitionException [1]
    {   
        Identifier value = default(Identifier);

        IToken NonQuotedIdentifier6 = null;
        IToken QuotedIdentifier7 = null;

        try 
    	{
            // MacroScope\\MacroScope.g:706:41: ( NonQuotedIdentifier | QuotedIdentifier )
            int alt77 = 2;
            int LA77_0 = input.LA(1);

            if ( (LA77_0 == NonQuotedIdentifier) )
            {
                alt77 = 1;
            }
            else if ( (LA77_0 == QuotedIdentifier) )
            {
                alt77 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d77s0 =
                    new NoViableAltException("", 77, 0, input);

                throw nvae_d77s0;
            }
            switch (alt77) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:707:2: NonQuotedIdentifier
                    {
                    	NonQuotedIdentifier6=(IToken)Match(input,NonQuotedIdentifier,FOLLOW_NonQuotedIdentifier_in_identifier2974); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new Identifier(((NonQuotedIdentifier6 != null) ? NonQuotedIdentifier6.Text : null));
                    	  	
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:710:4: QuotedIdentifier
                    {
                    	QuotedIdentifier7=(IToken)Match(input,QuotedIdentifier,FOLLOW_QuotedIdentifier_in_identifier2981); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new Identifier(((QuotedIdentifier7 != null) ? QuotedIdentifier7.Text : null));
                    	  	
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "identifier"


    // $ANTLR start "typeIdentifier"
    // MacroScope\\MacroScope.g:715:1: typeIdentifier returns [ string value ] : NonQuotedIdentifier ;
    public string typeIdentifier() // throws RecognitionException [1]
    {   
        string value = default(string);

        IToken NonQuotedIdentifier8 = null;

        try 
    	{
            // MacroScope\\MacroScope.g:715:41: ( NonQuotedIdentifier )
            // MacroScope\\MacroScope.g:716:2: NonQuotedIdentifier
            {
            	NonQuotedIdentifier8=(IToken)Match(input,NonQuotedIdentifier,FOLLOW_NonQuotedIdentifier_in_typeIdentifier2998); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  ((NonQuotedIdentifier8 != null) ? NonQuotedIdentifier8.Text : null); 
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "typeIdentifier"


    // $ANTLR start "constant"
    // MacroScope\\MacroScope.g:719:1: constant returns [ INode value ] : (i= nonNegativeInteger | Real | NULL | s= stringLiteral | j= intervalLiteral | HexLiteral | MAccessDateTime | Iso8601DateTime | TIMESTAMP s= stringLiteral );
    public INode constant() // throws RecognitionException [1]
    {   
        INode value = default(INode);

        IToken Real9 = null;
        IToken HexLiteral10 = null;
        IToken MAccessDateTime11 = null;
        IToken Iso8601DateTime12 = null;
        int i = default(int);

        StringValue s = default(StringValue);

        Interval j = default(Interval);


        try 
    	{
            // MacroScope\\MacroScope.g:719:34: (i= nonNegativeInteger | Real | NULL | s= stringLiteral | j= intervalLiteral | HexLiteral | MAccessDateTime | Iso8601DateTime | TIMESTAMP s= stringLiteral )
            int alt78 = 9;
            switch ( input.LA(1) ) 
            {
            case Integer:
            	{
                alt78 = 1;
                }
                break;
            case Real:
            	{
                alt78 = 2;
                }
                break;
            case NULL:
            	{
                alt78 = 3;
                }
                break;
            case UnicodeStringLiteral:
            case AsciiStringLiteral:
            	{
                alt78 = 4;
                }
                break;
            case INTERVAL:
            	{
                alt78 = 5;
                }
                break;
            case HexLiteral:
            	{
                alt78 = 6;
                }
                break;
            case MAccessDateTime:
            	{
                alt78 = 7;
                }
                break;
            case Iso8601DateTime:
            	{
                alt78 = 8;
                }
                break;
            case TIMESTAMP:
            	{
                alt78 = 9;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	    NoViableAltException nvae_d78s0 =
            	        new NoViableAltException("", 78, 0, input);

            	    throw nvae_d78s0;
            }

            switch (alt78) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:720:2: i= nonNegativeInteger
                    {
                    	PushFollow(FOLLOW_nonNegativeInteger_in_constant3019);
                    	i = nonNegativeInteger();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  new IntegerValue(i); 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:721:4: Real
                    {
                    	Real9=(IToken)Match(input,Real,FOLLOW_Real_in_constant3026); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  new DoubleValue(DoubleValue.Parse(((Real9 != null) ? Real9.Text : null))); 
                    	}

                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:722:4: NULL
                    {
                    	Match(input,NULL,FOLLOW_NULL_in_constant3033); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  NullValue.Value; 
                    	}

                    }
                    break;
                case 4 :
                    // MacroScope\\MacroScope.g:723:4: s= stringLiteral
                    {
                    	PushFollow(FOLLOW_stringLiteral_in_constant3044);
                    	s = stringLiteral();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  s; 
                    	}

                    }
                    break;
                case 5 :
                    // MacroScope\\MacroScope.g:724:4: j= intervalLiteral
                    {
                    	PushFollow(FOLLOW_intervalLiteral_in_constant3055);
                    	j = intervalLiteral();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  j; 
                    	}

                    }
                    break;
                case 6 :
                    // MacroScope\\MacroScope.g:725:4: HexLiteral
                    {
                    	HexLiteral10=(IToken)Match(input,HexLiteral,FOLLOW_HexLiteral_in_constant3062); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new IntegerValue(
                    	  			IntegerValue.ParseHex(((HexLiteral10 != null) ? HexLiteral10.Text : null)));
                    	  	
                    	}

                    }
                    break;
                case 7 :
                    // MacroScope\\MacroScope.g:730:4: MAccessDateTime
                    {
                    	MAccessDateTime11=(IToken)Match(input,MAccessDateTime,FOLLOW_MAccessDateTime_in_constant3071); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new LiteralDateTime(((MAccessDateTime11 != null) ? MAccessDateTime11.Text : null));
                    	  	
                    	}

                    }
                    break;
                case 8 :
                    // MacroScope\\MacroScope.g:734:4: Iso8601DateTime
                    {
                    	Iso8601DateTime12=(IToken)Match(input,Iso8601DateTime,FOLLOW_Iso8601DateTime_in_constant3080); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new LiteralDateTime(((Iso8601DateTime12 != null) ? Iso8601DateTime12.Text : null));
                    	  	
                    	}

                    }
                    break;
                case 9 :
                    // MacroScope\\MacroScope.g:737:4: TIMESTAMP s= stringLiteral
                    {
                    	Match(input,TIMESTAMP,FOLLOW_TIMESTAMP_in_constant3087); if (state.failed) return value;
                    	PushFollow(FOLLOW_stringLiteral_in_constant3093);
                    	s = stringLiteral();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{

                    	  		value =  new LiteralDateTime(s);
                    	  	
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "constant"


    // $ANTLR start "intervalLiteral"
    // MacroScope\\MacroScope.g:743:1: intervalLiteral returns [ Interval value ] : INTERVAL (u= unaryOperator )? AsciiStringLiteral d= datetimeField ( LPAREN Integer RPAREN )? ;
    public Interval intervalLiteral() // throws RecognitionException [1]
    {   
        Interval value = default(Interval);

        IToken AsciiStringLiteral13 = null;
        IToken Integer14 = null;
        ExpressionOperator u = default(ExpressionOperator);

        DateTimeUnit d = default(DateTimeUnit);


         bool positive = true; int intervalNumber = 0; 
        try 
    	{
            // MacroScope\\MacroScope.g:744:57: ( INTERVAL (u= unaryOperator )? AsciiStringLiteral d= datetimeField ( LPAREN Integer RPAREN )? )
            // MacroScope\\MacroScope.g:745:2: INTERVAL (u= unaryOperator )? AsciiStringLiteral d= datetimeField ( LPAREN Integer RPAREN )?
            {
            	Match(input,INTERVAL,FOLLOW_INTERVAL_in_intervalLiteral3117); if (state.failed) return value;
            	// MacroScope\\MacroScope.g:745:11: (u= unaryOperator )?
            	int alt79 = 2;
            	int LA79_0 = input.LA(1);

            	if ( ((LA79_0 >= PLUS && LA79_0 <= MINUS)) )
            	{
            	    alt79 = 1;
            	}
            	switch (alt79) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:745:13: u= unaryOperator
            	        {
            	        	PushFollow(FOLLOW_unaryOperator_in_intervalLiteral3125);
            	        	u = unaryOperator();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   
            	        	  			positive = (u == ExpressionOperator.Plus);
            	        	  		
            	        	}

            	        }
            	        break;

            	}

            	AsciiStringLiteral13=(IToken)Match(input,AsciiStringLiteral,FOLLOW_AsciiStringLiteral_in_intervalLiteral3132); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  			intervalNumber = Interval.Parse(
            	  				((AsciiStringLiteral13 != null) ? AsciiStringLiteral13.Text : null));
            	  		
            	}
            	PushFollow(FOLLOW_datetimeField_in_intervalLiteral3140);
            	d = datetimeField();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{

            	  			value =  new Interval(positive, intervalNumber,
            	  				d);
            	  		
            	}
            	// MacroScope\\MacroScope.g:753:5: ( LPAREN Integer RPAREN )?
            	int alt80 = 2;
            	int LA80_0 = input.LA(1);

            	if ( (LA80_0 == LPAREN) )
            	{
            	    alt80 = 1;
            	}
            	switch (alt80) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:753:7: LPAREN Integer RPAREN
            	        {
            	        	Match(input,LPAREN,FOLLOW_LPAREN_in_intervalLiteral3146); if (state.failed) return value;
            	        	Integer14=(IToken)Match(input,Integer,FOLLOW_Integer_in_intervalLiteral3148); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{

            	        	  			value.Precision = int.Parse(((Integer14 != null) ? Integer14.Text : null));
            	        	  		
            	        	}
            	        	Match(input,RPAREN,FOLLOW_RPAREN_in_intervalLiteral3152); if (state.failed) return value;

            	        }
            	        break;

            	}


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "intervalLiteral"


    // $ANTLR start "nonNegativeInteger"
    // MacroScope\\MacroScope.g:758:1: nonNegativeInteger returns [ int value ] : Integer ;
    public int nonNegativeInteger() // throws RecognitionException [1]
    {   
        int value = default(int);

        IToken Integer15 = null;

        try 
    	{
            // MacroScope\\MacroScope.g:758:42: ( Integer )
            // MacroScope\\MacroScope.g:759:2: Integer
            {
            	Integer15=(IToken)Match(input,Integer,FOLLOW_Integer_in_nonNegativeInteger3170); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  int.Parse(((Integer15 != null) ? Integer15.Text : null)); 
            	}

            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "nonNegativeInteger"


    // $ANTLR start "unaryOperator"
    // MacroScope\\MacroScope.g:762:1: unaryOperator returns [ ExpressionOperator value ] : ( PLUS | MINUS );
    public ExpressionOperator unaryOperator() // throws RecognitionException [1]
    {   
        ExpressionOperator value = default(ExpressionOperator);

        try 
    	{
            // MacroScope\\MacroScope.g:762:52: ( PLUS | MINUS )
            int alt81 = 2;
            int LA81_0 = input.LA(1);

            if ( (LA81_0 == PLUS) )
            {
                alt81 = 1;
            }
            else if ( (LA81_0 == MINUS) )
            {
                alt81 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d81s0 =
                    new NoViableAltException("", 81, 0, input);

                throw nvae_d81s0;
            }
            switch (alt81) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:763:2: PLUS
                    {
                    	Match(input,PLUS,FOLLOW_PLUS_in_unaryOperator3187); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.Plus; 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:764:4: MINUS
                    {
                    	Match(input,MINUS,FOLLOW_MINUS_in_unaryOperator3194); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.Minus; 
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "unaryOperator"


    // $ANTLR start "additiveOperator"
    // MacroScope\\MacroScope.g:767:1: additiveOperator returns [ ExpressionOperator value ] : ( PLUS | MINUS | STRCONCAT );
    public ExpressionOperator additiveOperator() // throws RecognitionException [1]
    {   
        ExpressionOperator value = default(ExpressionOperator);

        try 
    	{
            // MacroScope\\MacroScope.g:767:55: ( PLUS | MINUS | STRCONCAT )
            int alt82 = 3;
            switch ( input.LA(1) ) 
            {
            case PLUS:
            	{
                alt82 = 1;
                }
                break;
            case MINUS:
            	{
                alt82 = 2;
                }
                break;
            case STRCONCAT:
            	{
                alt82 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	    NoViableAltException nvae_d82s0 =
            	        new NoViableAltException("", 82, 0, input);

            	    throw nvae_d82s0;
            }

            switch (alt82) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:768:2: PLUS
                    {
                    	Match(input,PLUS,FOLLOW_PLUS_in_additiveOperator3211); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.Plus; 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:769:4: MINUS
                    {
                    	Match(input,MINUS,FOLLOW_MINUS_in_additiveOperator3218); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.Minus; 
                    	}

                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:770:4: STRCONCAT
                    {
                    	Match(input,STRCONCAT,FOLLOW_STRCONCAT_in_additiveOperator3225); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.StrConcat; 
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "additiveOperator"


    // $ANTLR start "multiplicativeArithmeticOperator"
    // MacroScope\\MacroScope.g:773:1: multiplicativeArithmeticOperator returns [ ExpressionOperator value ] : ( STAR | DIVIDE | MOD );
    public ExpressionOperator multiplicativeArithmeticOperator() // throws RecognitionException [1]
    {   
        ExpressionOperator value = default(ExpressionOperator);

        try 
    	{
            // MacroScope\\MacroScope.g:773:71: ( STAR | DIVIDE | MOD )
            int alt83 = 3;
            switch ( input.LA(1) ) 
            {
            case STAR:
            	{
                alt83 = 1;
                }
                break;
            case DIVIDE:
            	{
                alt83 = 2;
                }
                break;
            case MOD:
            	{
                alt83 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	    NoViableAltException nvae_d83s0 =
            	        new NoViableAltException("", 83, 0, input);

            	    throw nvae_d83s0;
            }

            switch (alt83) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:774:2: STAR
                    {
                    	Match(input,STAR,FOLLOW_STAR_in_multiplicativeArithmeticOperator3246); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.Mult; 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:775:4: DIVIDE
                    {
                    	Match(input,DIVIDE,FOLLOW_DIVIDE_in_multiplicativeArithmeticOperator3253); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.Div; 
                    	}

                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:776:4: MOD
                    {
                    	Match(input,MOD,FOLLOW_MOD_in_multiplicativeArithmeticOperator3260); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.Mod; 
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "multiplicativeArithmeticOperator"


    // $ANTLR start "comparisonOperator"
    // MacroScope\\MacroScope.g:779:1: comparisonOperator returns [ ExpressionOperator value ] : ( ASSIGNEQUAL | NOTEQUAL1 | NOTEQUAL2 | LESSTHANOREQUALTO1 | LESSTHAN | GREATERTHANOREQUALTO1 | GREATERTHAN );
    public ExpressionOperator comparisonOperator() // throws RecognitionException [1]
    {   
        ExpressionOperator value = default(ExpressionOperator);

        try 
    	{
            // MacroScope\\MacroScope.g:779:57: ( ASSIGNEQUAL | NOTEQUAL1 | NOTEQUAL2 | LESSTHANOREQUALTO1 | LESSTHAN | GREATERTHANOREQUALTO1 | GREATERTHAN )
            int alt84 = 7;
            switch ( input.LA(1) ) 
            {
            case ASSIGNEQUAL:
            	{
                alt84 = 1;
                }
                break;
            case NOTEQUAL1:
            	{
                alt84 = 2;
                }
                break;
            case NOTEQUAL2:
            	{
                alt84 = 3;
                }
                break;
            case LESSTHANOREQUALTO1:
            	{
                alt84 = 4;
                }
                break;
            case LESSTHAN:
            	{
                alt84 = 5;
                }
                break;
            case GREATERTHANOREQUALTO1:
            	{
                alt84 = 6;
                }
                break;
            case GREATERTHAN:
            	{
                alt84 = 7;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	    NoViableAltException nvae_d84s0 =
            	        new NoViableAltException("", 84, 0, input);

            	    throw nvae_d84s0;
            }

            switch (alt84) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:780:2: ASSIGNEQUAL
                    {
                    	Match(input,ASSIGNEQUAL,FOLLOW_ASSIGNEQUAL_in_comparisonOperator3281); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.Equal; 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:781:4: NOTEQUAL1
                    {
                    	Match(input,NOTEQUAL1,FOLLOW_NOTEQUAL1_in_comparisonOperator3288); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.NotEqual; 
                    	}

                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:782:4: NOTEQUAL2
                    {
                    	Match(input,NOTEQUAL2,FOLLOW_NOTEQUAL2_in_comparisonOperator3295); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.NotEqual; 
                    	}

                    }
                    break;
                case 4 :
                    // MacroScope\\MacroScope.g:783:4: LESSTHANOREQUALTO1
                    {
                    	Match(input,LESSTHANOREQUALTO1,FOLLOW_LESSTHANOREQUALTO1_in_comparisonOperator3302); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.LessOrEqual; 
                    	}

                    }
                    break;
                case 5 :
                    // MacroScope\\MacroScope.g:784:4: LESSTHAN
                    {
                    	Match(input,LESSTHAN,FOLLOW_LESSTHAN_in_comparisonOperator3309); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.Less; 
                    	}

                    }
                    break;
                case 6 :
                    // MacroScope\\MacroScope.g:785:4: GREATERTHANOREQUALTO1
                    {
                    	Match(input,GREATERTHANOREQUALTO1,FOLLOW_GREATERTHANOREQUALTO1_in_comparisonOperator3316); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.GreaterOrEqual; 
                    	}

                    }
                    break;
                case 7 :
                    // MacroScope\\MacroScope.g:786:4: GREATERTHAN
                    {
                    	Match(input,GREATERTHAN,FOLLOW_GREATERTHAN_in_comparisonOperator3323); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  ExpressionOperator.Greater; 
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "comparisonOperator"


    // $ANTLR start "unionOperator"
    // MacroScope\\MacroScope.g:789:1: unionOperator returns [ bool value ] : UNION ( ALL )? ;
    public bool unionOperator() // throws RecognitionException [1]
    {   
        bool value = default(bool);

        try 
    	{
            // MacroScope\\MacroScope.g:789:38: ( UNION ( ALL )? )
            // MacroScope\\MacroScope.g:790:2: UNION ( ALL )?
            {
            	Match(input,UNION,FOLLOW_UNION_in_unionOperator3340); if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	   value =  false; 
            	}
            	// MacroScope\\MacroScope.g:791:2: ( ALL )?
            	int alt85 = 2;
            	int LA85_0 = input.LA(1);

            	if ( (LA85_0 == ALL) )
            	{
            	    alt85 = 1;
            	}
            	switch (alt85) 
            	{
            	    case 1 :
            	        // MacroScope\\MacroScope.g:791:4: ALL
            	        {
            	        	Match(input,ALL,FOLLOW_ALL_in_unionOperator3347); if (state.failed) return value;
            	        	if ( (state.backtracking==0) )
            	        	{
            	        	   value =  true; 
            	        	}

            	        }
            	        break;

            	}


            }

        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "unionOperator"


    // $ANTLR start "datetimeField"
    // MacroScope\\MacroScope.g:794:1: datetimeField returns [ DateTimeUnit value ] : ( YEAR | MONTH | DAY | HOUR | MINUTE | SECOND );
    public DateTimeUnit datetimeField() // throws RecognitionException [1]
    {   
        DateTimeUnit value = default(DateTimeUnit);

        try 
    	{
            // MacroScope\\MacroScope.g:794:46: ( YEAR | MONTH | DAY | HOUR | MINUTE | SECOND )
            int alt86 = 6;
            switch ( input.LA(1) ) 
            {
            case YEAR:
            	{
                alt86 = 1;
                }
                break;
            case MONTH:
            	{
                alt86 = 2;
                }
                break;
            case DAY:
            	{
                alt86 = 3;
                }
                break;
            case HOUR:
            	{
                alt86 = 4;
                }
                break;
            case MINUTE:
            	{
                alt86 = 5;
                }
                break;
            case SECOND:
            	{
                alt86 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return value;}
            	    NoViableAltException nvae_d86s0 =
            	        new NoViableAltException("", 86, 0, input);

            	    throw nvae_d86s0;
            }

            switch (alt86) 
            {
                case 1 :
                    // MacroScope\\MacroScope.g:795:2: YEAR
                    {
                    	Match(input,YEAR,FOLLOW_YEAR_in_datetimeField3367); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  DateTimeUnit.Year; 
                    	}

                    }
                    break;
                case 2 :
                    // MacroScope\\MacroScope.g:796:4: MONTH
                    {
                    	Match(input,MONTH,FOLLOW_MONTH_in_datetimeField3374); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  DateTimeUnit.Month; 
                    	}

                    }
                    break;
                case 3 :
                    // MacroScope\\MacroScope.g:797:4: DAY
                    {
                    	Match(input,DAY,FOLLOW_DAY_in_datetimeField3381); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  DateTimeUnit.Day; 
                    	}

                    }
                    break;
                case 4 :
                    // MacroScope\\MacroScope.g:798:4: HOUR
                    {
                    	Match(input,HOUR,FOLLOW_HOUR_in_datetimeField3388); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  DateTimeUnit.Hour; 
                    	}

                    }
                    break;
                case 5 :
                    // MacroScope\\MacroScope.g:799:4: MINUTE
                    {
                    	Match(input,MINUTE,FOLLOW_MINUTE_in_datetimeField3395); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  DateTimeUnit.Minute; 
                    	}

                    }
                    break;
                case 6 :
                    // MacroScope\\MacroScope.g:800:4: SECOND
                    {
                    	Match(input,SECOND,FOLLOW_SECOND_in_datetimeField3402); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	   value =  DateTimeUnit.Second; 
                    	}

                    }
                    break;

            }
        }

        finally 
    	{
        }
        return value;
    }
    // $ANTLR end "datetimeField"

    // $ANTLR start "synpred1_MacroScope"
    public void synpred1_MacroScope_fragment() {
        // MacroScope\\MacroScope.g:205:3: ( bracketedSearchCondition )
        // MacroScope\\MacroScope.g:205:4: bracketedSearchCondition
        {
        	PushFollow(FOLLOW_bracketedSearchCondition_in_synpred1_MacroScope1047);
        	bracketedSearchCondition();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_MacroScope"

    // $ANTLR start "synpred2_MacroScope"
    public void synpred2_MacroScope_fragment() {
        // MacroScope\\MacroScope.g:306:5: ( selectStatement )
        // MacroScope\\MacroScope.g:306:7: selectStatement
        {
        	PushFollow(FOLLOW_selectStatement_in_synpred2_MacroScope1308);
        	selectStatement();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_MacroScope"

    // $ANTLR start "synpred3_MacroScope"
    public void synpred3_MacroScope_fragment() {
        // MacroScope\\MacroScope.g:349:3: ( alias2 )
        // MacroScope\\MacroScope.g:349:4: alias2
        {
        	PushFollow(FOLLOW_alias2_in_synpred3_MacroScope1494);
        	alias2();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_MacroScope"

    // $ANTLR start "synpred4_MacroScope"
    public void synpred4_MacroScope_fragment() {
        // MacroScope\\MacroScope.g:357:5: ( tableColumns )
        // MacroScope\\MacroScope.g:357:6: tableColumns
        {
        	PushFollow(FOLLOW_tableColumns_in_synpred4_MacroScope1531);
        	tableColumns();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_MacroScope"

    // $ANTLR start "synpred5_MacroScope"
    public void synpred5_MacroScope_fragment() {
        // MacroScope\\MacroScope.g:382:3: ( joinedTables )
        // MacroScope\\MacroScope.g:382:4: joinedTables
        {
        	PushFollow(FOLLOW_joinedTables_in_synpred5_MacroScope1670);
        	joinedTables();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_MacroScope"

    // $ANTLR start "synpred6_MacroScope"
    public void synpred6_MacroScope_fragment() {
        // MacroScope\\MacroScope.g:399:4: ( function )
        // MacroScope\\MacroScope.g:399:5: function
        {
        	PushFollow(FOLLOW_function_in_synpred6_MacroScope1731);
        	function();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_MacroScope"

    // $ANTLR start "synpred7_MacroScope"
    public void synpred7_MacroScope_fragment() {
        // MacroScope\\MacroScope.g:480:11: ( selectStatement )
        // MacroScope\\MacroScope.g:480:12: selectStatement
        {
        	PushFollow(FOLLOW_selectStatement_in_synpred7_MacroScope2166);
        	selectStatement();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_MacroScope"

    // $ANTLR start "synpred8_MacroScope"
    public void synpred8_MacroScope_fragment() {
        // MacroScope\\MacroScope.g:519:5: ( function )
        // MacroScope\\MacroScope.g:519:6: function
        {
        	PushFollow(FOLLOW_function_in_synpred8_MacroScope2264);
        	function();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_MacroScope"

    // Delegated rules

   	public bool synpred3_MacroScope() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_MacroScope_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred6_MacroScope() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred6_MacroScope_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred1_MacroScope() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_MacroScope_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred4_MacroScope() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_MacroScope_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred7_MacroScope() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_MacroScope_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred2_MacroScope() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_MacroScope_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred8_MacroScope() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_MacroScope_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred5_MacroScope() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred5_MacroScope_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA26 dfa26;
   	protected DFA32 dfa32;
   	protected DFA39 dfa39;
   	protected DFA56 dfa56;
   	protected DFA58 dfa58;
	private void InitializeCyclicDFAs()
	{
    	this.dfa26 = new DFA26(this);
    	this.dfa32 = new DFA32(this);
    	this.dfa39 = new DFA39(this);
    	this.dfa56 = new DFA56(this);
    	this.dfa58 = new DFA58(this);
	    this.dfa26.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA26_SpecialStateTransition);
	    this.dfa32.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA32_SpecialStateTransition);
	    this.dfa39.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA39_SpecialStateTransition);
	    this.dfa56.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA56_SpecialStateTransition);
	    this.dfa58.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA58_SpecialStateTransition);
	}

    const string DFA26_eotS =
        "\x1a\uffff";
    const string DFA26_eofS =
        "\x1a\uffff";
    const string DFA26_minS =
        "\x01\x06\x01\x00\x18\uffff";
    const string DFA26_maxS =
        "\x01\x4a\x01\x00\x18\uffff";
    const string DFA26_acceptS =
        "\x02\uffff\x01\x02\x16\uffff\x01\x01";
    const string DFA26_specialS =
        "\x01\uffff\x01\x00\x18\uffff}>";
    static readonly string[] DFA26_transitionS = {
            "\x01\x01\x0d\uffff\x01\x02\x0b\uffff\x01\x02\x04\uffff\x01"+
            "\x02\x04\uffff\x02\x02\x07\uffff\x03\x02\x01\uffff\x03\x02\x04"+
            "\uffff\x01\x02\x01\uffff\x0b\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA26_eot = DFA.UnpackEncodedString(DFA26_eotS);
    static readonly short[] DFA26_eof = DFA.UnpackEncodedString(DFA26_eofS);
    static readonly char[] DFA26_min = DFA.UnpackEncodedStringToUnsignedChars(DFA26_minS);
    static readonly char[] DFA26_max = DFA.UnpackEncodedStringToUnsignedChars(DFA26_maxS);
    static readonly short[] DFA26_accept = DFA.UnpackEncodedString(DFA26_acceptS);
    static readonly short[] DFA26_special = DFA.UnpackEncodedString(DFA26_specialS);
    static readonly short[][] DFA26_transition = DFA.UnpackEncodedStringArray(DFA26_transitionS);

    protected class DFA26 : DFA
    {
        public DFA26(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 26;
            this.eot = DFA26_eot;
            this.eof = DFA26_eof;
            this.min = DFA26_min;
            this.max = DFA26_max;
            this.accept = DFA26_accept;
            this.special = DFA26_special;
            this.transition = DFA26_transition;

        }

        override public string Description
        {
            get { return "204:31: ( ( bracketedSearchCondition )=>e= bracketedSearchCondition | p= predicate )"; }
        }

    }


    protected internal int DFA26_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA26_1 = input.LA(1);

                   	 
                   	int index26_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_MacroScope()) ) { s = 25; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index26_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae26 =
            new NoViableAltException(dfa.Description, 26, _s, input);
        dfa.Error(nvae26);
        throw nvae26;
    }
    const string DFA32_eotS =
        "\x19\uffff";
    const string DFA32_eofS =
        "\x19\uffff";
    const string DFA32_minS =
        "\x01\x06\x01\uffff\x01\x00\x16\uffff";
    const string DFA32_maxS =
        "\x01\x4a\x01\uffff\x01\x00\x16\uffff";
    const string DFA32_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x15\uffff";
    const string DFA32_specialS =
        "\x01\x00\x01\uffff\x01\x01\x16\uffff}>";
    static readonly string[] DFA32_transitionS = {
            "\x01\x02\x09\uffff\x01\x01\x03\uffff\x01\x03\x0b\uffff\x01"+
            "\x03\x09\uffff\x02\x03\x07\uffff\x03\x03\x01\uffff\x03\x03\x04"+
            "\uffff\x01\x03\x01\uffff\x0b\x03",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA32_eot = DFA.UnpackEncodedString(DFA32_eotS);
    static readonly short[] DFA32_eof = DFA.UnpackEncodedString(DFA32_eofS);
    static readonly char[] DFA32_min = DFA.UnpackEncodedStringToUnsignedChars(DFA32_minS);
    static readonly char[] DFA32_max = DFA.UnpackEncodedStringToUnsignedChars(DFA32_maxS);
    static readonly short[] DFA32_accept = DFA.UnpackEncodedString(DFA32_acceptS);
    static readonly short[] DFA32_special = DFA.UnpackEncodedString(DFA32_specialS);
    static readonly short[][] DFA32_transition = DFA.UnpackEncodedStringArray(DFA32_transitionS);

    protected class DFA32 : DFA
    {
        public DFA32(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 32;
            this.eot = DFA32_eot;
            this.eof = DFA32_eof;
            this.min = DFA32_min;
            this.max = DFA32_max;
            this.accept = DFA32_accept;
            this.special = DFA32_special;
            this.transition = DFA32_transition;

        }

        override public string Description
        {
            get { return "305:16: ( ( selectStatement )=>s= selectStatement | e= expression ( COMMA e= expression )* )"; }
        }

    }


    protected internal int DFA32_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA32_0 = input.LA(1);

                   	 
                   	int index32_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA32_0 == SELECT) && (synpred2_MacroScope()) ) { s = 1; }

                   	else if ( (LA32_0 == LPAREN) ) { s = 2; }

                   	else if ( (LA32_0 == Integer || LA32_0 == NULL || (LA32_0 >= LEFT && LA32_0 <= RIGHT) || (LA32_0 >= PLACEHOLDER && LA32_0 <= SUBSTRING) || (LA32_0 >= EXTRACT && LA32_0 <= CASE) || LA32_0 == CAST || (LA32_0 >= UnicodeStringLiteral && LA32_0 <= MINUS)) ) { s = 3; }

                   	 
                   	input.Seek(index32_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA32_2 = input.LA(1);

                   	 
                   	int index32_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred2_MacroScope()) ) { s = 1; }

                   	else if ( (true) ) { s = 3; }

                   	 
                   	input.Seek(index32_2);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae32 =
            new NoViableAltException(dfa.Description, 32, _s, input);
        dfa.Error(nvae32);
        throw nvae32;
    }
    const string DFA39_eotS =
        "\x09\uffff";
    const string DFA39_eofS =
        "\x01\uffff\x02\x03\x04\uffff\x02\x03";
    const string DFA39_minS =
        "\x02\x06\x01\x07\x02\uffff\x01\x38\x01\uffff\x02\x07";
    const string DFA39_maxS =
        "\x01\x4a\x02\x54\x02\uffff\x01\x42\x01\uffff\x02\x54";
    const string DFA39_acceptS =
        "\x03\uffff\x01\x03\x01\x01\x01\uffff\x01\x02\x02\uffff";
    const string DFA39_specialS =
        "\x01\uffff\x01\x00\x01\x03\x04\uffff\x01\x01\x01\x02}>";
    static readonly string[] DFA39_transitionS = {
            "\x01\x03\x0d\uffff\x01\x03\x0b\uffff\x01\x03\x09\uffff\x02"+
            "\x03\x07\uffff\x03\x03\x01\uffff\x01\x03\x01\x01\x01\x03\x04"+
            "\uffff\x01\x03\x01\uffff\x02\x03\x01\x02\x08\x03",
            "\x02\x03\x04\uffff\x02\x03\x01\x04\x06\uffff\x02\x03\x03\uffff"+
            "\x01\x03\x0d\uffff\x01\x03\x08\uffff\x01\x03\x01\x06\x05\uffff"+
            "\x01\x03\x06\uffff\x01\x05\x02\uffff\x01\x03\x06\uffff\x05\x03"+
            "\x06\uffff\x01\x03",
            "\x01\x03\x04\uffff\x02\x03\x01\x04\x06\uffff\x02\x03\x03\uffff"+
            "\x01\x03\x0d\uffff\x01\x03\x08\uffff\x01\x03\x01\x06\x05\uffff"+
            "\x01\x03\x06\uffff\x01\x05\x02\uffff\x01\x03\x06\uffff\x05\x03"+
            "\x06\uffff\x01\x03",
            "",
            "",
            "\x01\x07\x09\uffff\x01\x08",
            "",
            "\x01\x03\x04\uffff\x02\x03\x07\uffff\x02\x03\x03\uffff\x01"+
            "\x03\x0d\uffff\x01\x03\x08\uffff\x01\x03\x01\x06\x05\uffff\x01"+
            "\x03\x06\uffff\x01\x05\x02\uffff\x01\x03\x06\uffff\x05\x03\x06"+
            "\uffff\x01\x03",
            "\x01\x03\x04\uffff\x02\x03\x07\uffff\x02\x03\x03\uffff\x01"+
            "\x03\x0d\uffff\x01\x03\x08\uffff\x01\x03\x01\x06\x05\uffff\x01"+
            "\x03\x06\uffff\x01\x05\x02\uffff\x01\x03\x06\uffff\x05\x03\x06"+
            "\uffff\x01\x03"
    };

    static readonly short[] DFA39_eot = DFA.UnpackEncodedString(DFA39_eotS);
    static readonly short[] DFA39_eof = DFA.UnpackEncodedString(DFA39_eofS);
    static readonly char[] DFA39_min = DFA.UnpackEncodedStringToUnsignedChars(DFA39_minS);
    static readonly char[] DFA39_max = DFA.UnpackEncodedStringToUnsignedChars(DFA39_maxS);
    static readonly short[] DFA39_accept = DFA.UnpackEncodedString(DFA39_acceptS);
    static readonly short[] DFA39_special = DFA.UnpackEncodedString(DFA39_specialS);
    static readonly short[][] DFA39_transition = DFA.UnpackEncodedStringArray(DFA39_transitionS);

    protected class DFA39 : DFA
    {
        public DFA39(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 39;
            this.eot = DFA39_eot;
            this.eof = DFA39_eof;
            this.min = DFA39_min;
            this.max = DFA39_max;
            this.accept = DFA39_accept;
            this.special = DFA39_special;
            this.transition = DFA39_transition;

        }

        override public string Description
        {
            get { return "347:4: ( ( alias2 )=> (a= alias2 e= expression ) | ( tableColumns )=>t= tableColumns | e= expression (a= alias1 )? )"; }
        }

    }


    protected internal int DFA39_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA39_1 = input.LA(1);

                   	 
                   	int index39_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA39_1 == ASSIGNEQUAL) && (synpred3_MacroScope()) ) { s = 4; }

                   	else if ( (LA39_1 == EOF || (LA39_1 >= LPAREN && LA39_1 <= RPAREN) || (LA39_1 >= FROM && LA39_1 <= COMMA) || (LA39_1 >= WHERE && LA39_1 <= ORDER) || LA39_1 == GROUP || LA39_1 == STAR || LA39_1 == AS || LA39_1 == NonQuotedIdentifier || LA39_1 == QuotedIdentifier || (LA39_1 >= PLUS && LA39_1 <= MOD) || LA39_1 == UNION) ) { s = 3; }

                   	else if ( (LA39_1 == DOT) ) { s = 5; }

                   	else if ( (LA39_1 == DOT_STAR) && (synpred4_MacroScope()) ) { s = 6; }

                   	 
                   	input.Seek(index39_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA39_7 = input.LA(1);

                   	 
                   	int index39_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA39_7 == DOT_STAR) && (synpred4_MacroScope()) ) { s = 6; }

                   	else if ( (LA39_7 == DOT) ) { s = 5; }

                   	else if ( (LA39_7 == EOF || LA39_7 == RPAREN || (LA39_7 >= FROM && LA39_7 <= COMMA) || (LA39_7 >= WHERE && LA39_7 <= ORDER) || LA39_7 == GROUP || LA39_7 == STAR || LA39_7 == AS || LA39_7 == NonQuotedIdentifier || LA39_7 == QuotedIdentifier || (LA39_7 >= PLUS && LA39_7 <= MOD) || LA39_7 == UNION) ) { s = 3; }

                   	 
                   	input.Seek(index39_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA39_8 = input.LA(1);

                   	 
                   	int index39_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA39_8 == EOF || LA39_8 == RPAREN || (LA39_8 >= FROM && LA39_8 <= COMMA) || (LA39_8 >= WHERE && LA39_8 <= ORDER) || LA39_8 == GROUP || LA39_8 == STAR || LA39_8 == AS || LA39_8 == NonQuotedIdentifier || LA39_8 == QuotedIdentifier || (LA39_8 >= PLUS && LA39_8 <= MOD) || LA39_8 == UNION) ) { s = 3; }

                   	else if ( (LA39_8 == DOT) ) { s = 5; }

                   	else if ( (LA39_8 == DOT_STAR) && (synpred4_MacroScope()) ) { s = 6; }

                   	 
                   	input.Seek(index39_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA39_2 = input.LA(1);

                   	 
                   	int index39_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA39_2 == DOT) ) { s = 5; }

                   	else if ( (LA39_2 == DOT_STAR) && (synpred4_MacroScope()) ) { s = 6; }

                   	else if ( (LA39_2 == ASSIGNEQUAL) && (synpred3_MacroScope()) ) { s = 4; }

                   	else if ( (LA39_2 == EOF || LA39_2 == RPAREN || (LA39_2 >= FROM && LA39_2 <= COMMA) || (LA39_2 >= WHERE && LA39_2 <= ORDER) || LA39_2 == GROUP || LA39_2 == STAR || LA39_2 == AS || LA39_2 == NonQuotedIdentifier || LA39_2 == QuotedIdentifier || (LA39_2 >= PLUS && LA39_2 <= MOD) || LA39_2 == UNION) ) { s = 3; }

                   	 
                   	input.Seek(index39_2);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae39 =
            new NoViableAltException(dfa.Description, 39, _s, input);
        dfa.Error(nvae39);
        throw nvae39;
    }
    const string DFA56_eotS =
        "\x19\uffff";
    const string DFA56_eofS =
        "\x19\uffff";
    const string DFA56_minS =
        "\x01\x06\x01\uffff\x01\x00\x16\uffff";
    const string DFA56_maxS =
        "\x01\x4a\x01\uffff\x01\x00\x16\uffff";
    const string DFA56_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x15\uffff";
    const string DFA56_specialS =
        "\x01\x00\x01\uffff\x01\x01\x16\uffff}>";
    static readonly string[] DFA56_transitionS = {
            "\x01\x02\x09\uffff\x01\x01\x03\uffff\x01\x03\x0b\uffff\x01"+
            "\x03\x09\uffff\x02\x03\x07\uffff\x03\x03\x01\uffff\x03\x03\x04"+
            "\uffff\x01\x03\x01\uffff\x0b\x03",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA56_eot = DFA.UnpackEncodedString(DFA56_eotS);
    static readonly short[] DFA56_eof = DFA.UnpackEncodedString(DFA56_eofS);
    static readonly char[] DFA56_min = DFA.UnpackEncodedStringToUnsignedChars(DFA56_minS);
    static readonly char[] DFA56_max = DFA.UnpackEncodedStringToUnsignedChars(DFA56_maxS);
    static readonly short[] DFA56_accept = DFA.UnpackEncodedString(DFA56_acceptS);
    static readonly short[] DFA56_special = DFA.UnpackEncodedString(DFA56_specialS);
    static readonly short[][] DFA56_transition = DFA.UnpackEncodedStringArray(DFA56_transitionS);

    protected class DFA56 : DFA
    {
        public DFA56(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 56;
            this.eot = DFA56_eot;
            this.eof = DFA56_eof;
            this.min = DFA56_min;
            this.max = DFA56_max;
            this.accept = DFA56_accept;
            this.special = DFA56_special;
            this.transition = DFA56_transition;

        }

        override public string Description
        {
            get { return "480:9: ( ( selectStatement )=>s= selectStatement RPAREN | e= expression RPAREN )"; }
        }

    }


    protected internal int DFA56_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA56_0 = input.LA(1);

                   	 
                   	int index56_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA56_0 == SELECT) && (synpred7_MacroScope()) ) { s = 1; }

                   	else if ( (LA56_0 == LPAREN) ) { s = 2; }

                   	else if ( (LA56_0 == Integer || LA56_0 == NULL || (LA56_0 >= LEFT && LA56_0 <= RIGHT) || (LA56_0 >= PLACEHOLDER && LA56_0 <= SUBSTRING) || (LA56_0 >= EXTRACT && LA56_0 <= CASE) || LA56_0 == CAST || (LA56_0 >= UnicodeStringLiteral && LA56_0 <= MINUS)) ) { s = 3; }

                   	 
                   	input.Seek(index56_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA56_2 = input.LA(1);

                   	 
                   	int index56_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_MacroScope()) ) { s = 1; }

                   	else if ( (true) ) { s = 3; }

                   	 
                   	input.Seek(index56_2);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae56 =
            new NoViableAltException(dfa.Description, 56, _s, input);
        dfa.Error(nvae56);
        throw nvae56;
    }
    const string DFA58_eotS =
        "\x0e\uffff";
    const string DFA58_eofS =
        "\x06\uffff\x01\x0a\x07\uffff";
    const string DFA58_minS =
        "\x01\x06\x05\uffff\x01\x06\x07\uffff";
    const string DFA58_maxS =
        "\x01\x48\x05\uffff\x01\x54\x07\uffff";
    const string DFA58_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x02\x04\x01\uffff\x02\x04\x01"+
        "\x05\x01\x06\x01\x07\x01\x08\x01\x04";
    const string DFA58_specialS =
        "\x01\x00\x05\uffff\x01\x01\x07\uffff}>";
    static readonly string[] DFA58_transitionS = {
            "\x01\x09\x0d\uffff\x01\x01\x0b\uffff\x01\x01\x09\uffff\x01"+
            "\x07\x01\x08\x07\uffff\x01\x03\x01\x02\x01\x04\x01\uffff\x01"+
            "\x05\x01\x06\x01\x0b\x04\uffff\x01\x0c\x01\uffff\x02\x01\x01"+
            "\x0a\x06\x01",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0d\x01\x0a\x04\uffff\x03\x0a\x06\uffff\x02\x0a\x01\uffff"+
            "\x08\x0a\x01\uffff\x04\x0a\x03\uffff\x05\x0a\x01\uffff\x04\x0a"+
            "\x04\uffff\x01\x0a\x01\uffff\x01\x0a\x01\uffff\x04\x0a\x01\uffff"+
            "\x01\x0a\x02\uffff\x01\x0a\x06\uffff\x0c\x0a",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA58_eot = DFA.UnpackEncodedString(DFA58_eotS);
    static readonly short[] DFA58_eof = DFA.UnpackEncodedString(DFA58_eofS);
    static readonly char[] DFA58_min = DFA.UnpackEncodedStringToUnsignedChars(DFA58_minS);
    static readonly char[] DFA58_max = DFA.UnpackEncodedStringToUnsignedChars(DFA58_maxS);
    static readonly short[] DFA58_accept = DFA.UnpackEncodedString(DFA58_acceptS);
    static readonly short[] DFA58_special = DFA.UnpackEncodedString(DFA58_specialS);
    static readonly short[][] DFA58_transition = DFA.UnpackEncodedStringArray(DFA58_transitionS);

    protected class DFA58 : DFA
    {
        public DFA58(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 58;
            this.eot = DFA58_eot;
            this.eof = DFA58_eof;
            this.min = DFA58_min;
            this.max = DFA58_max;
            this.accept = DFA58_accept;
            this.special = DFA58_special;
            this.transition = DFA58_transition;

        }

        override public string Description
        {
            get { return "494:7: (c= constant | v= variableReference | PLACEHOLDER | ( function )=>f= function | e= bracketedTerm | d= dbObject | p= caseFunction | q= castFunction )"; }
        }

    }


    protected internal int DFA58_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA58_0 = input.LA(1);

                   	 
                   	int index58_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA58_0 == Integer || LA58_0 == NULL || (LA58_0 >= UnicodeStringLiteral && LA58_0 <= AsciiStringLiteral) || (LA58_0 >= Real && LA58_0 <= INTERVAL)) ) { s = 1; }

                   	else if ( (LA58_0 == Variable) ) { s = 2; }

                   	else if ( (LA58_0 == PLACEHOLDER) ) { s = 3; }

                   	else if ( (LA58_0 == SUBSTRING) && (synpred8_MacroScope()) ) { s = 4; }

                   	else if ( (LA58_0 == EXTRACT) && (synpred8_MacroScope()) ) { s = 5; }

                   	else if ( (LA58_0 == NonQuotedIdentifier) ) { s = 6; }

                   	else if ( (LA58_0 == LEFT) && (synpred8_MacroScope()) ) { s = 7; }

                   	else if ( (LA58_0 == RIGHT) && (synpred8_MacroScope()) ) { s = 8; }

                   	else if ( (LA58_0 == LPAREN) ) { s = 9; }

                   	else if ( (LA58_0 == QuotedIdentifier) ) { s = 10; }

                   	else if ( (LA58_0 == CASE) ) { s = 11; }

                   	else if ( (LA58_0 == CAST) ) { s = 12; }

                   	 
                   	input.Seek(index58_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA58_6 = input.LA(1);

                   	 
                   	int index58_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA58_6 == EOF || LA58_6 == RPAREN || (LA58_6 >= FROM && LA58_6 <= ASSIGNEQUAL) || (LA58_6 >= WHERE && LA58_6 <= ORDER) || (LA58_6 >= ASC && LA58_6 <= IS) || (LA58_6 >= LIKE && LA58_6 <= IN) || (LA58_6 >= STAR && LA58_6 <= FULL) || (LA58_6 >= JOIN && LA58_6 <= AS) || LA58_6 == FOR || LA58_6 == NonQuotedIdentifier || (LA58_6 >= WHEN && LA58_6 <= END) || LA58_6 == DOT || LA58_6 == QuotedIdentifier || (LA58_6 >= PLUS && LA58_6 <= UNION)) ) { s = 10; }

                   	else if ( (LA58_6 == LPAREN) && (synpred8_MacroScope()) ) { s = 13; }

                   	 
                   	input.Seek(index58_6);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae58 =
            new NoViableAltException(dfa.Description, 58, _s, input);
        dfa.Error(nvae58);
        throw nvae58;
    }
 

    public static readonly BitSet FOLLOW_insertStatement_in_statement66 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_statement68 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectStatement_in_statement79 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_statement81 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_updateStatement_in_statement92 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_statement94 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deleteStatement_in_statement105 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_statement107 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INSERT_in_insertStatement126 = new BitSet(new ulong[]{0x0100000000000020UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_INTO_in_insertStatement132 = new BitSet(new ulong[]{0x0100000000000020UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_dbObject_in_insertStatement143 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_insertStatement155 = new BitSet(new ulong[]{0x0100000000000060UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_columnNameList_in_insertStatement161 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_insertStatement163 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_VALUES_in_insertStatement169 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_insertStatement171 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_columnValueList_in_insertStatement177 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_insertStatement179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_queryExpression_in_selectStatement206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPDATE_in_updateStatement225 = new BitSet(new ulong[]{0x0100000000000020UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_dbObject_in_updateStatement235 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SET_in_updateStatement241 = new BitSet(new ulong[]{0x0100000000000060UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_assignmentList_in_updateStatement247 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_whereClause_in_updateStatement266 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DELETE_in_deleteStatement293 = new BitSet(new ulong[]{0x0100000000001020UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_FROM_in_deleteStatement299 = new BitSet(new ulong[]{0x0100000000000020UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_dbObject_in_deleteStatement310 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_whereClause_in_deleteStatement326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_assignmentList356 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_assignmentList362 = new BitSet(new ulong[]{0x0100000000000060UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_assignment_in_assignmentList368 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_column_in_assignment392 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ASSIGNEQUAL_in_assignment394 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_columnValue_in_assignment400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_column_in_columnNameList421 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_columnNameList429 = new BitSet(new ulong[]{0x0100000000000060UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_column_in_columnNameList435 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_columnValue_in_columnValueList459 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_columnValueList465 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_columnValue_in_columnValueList471 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_DEFAULT_in_columnValue491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_columnValue502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_subQueryExpression_in_queryExpression523 = new BitSet(new ulong[]{0x0000000000400002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_unionOperator_in_queryExpression535 = new BitSet(new ulong[]{0x0000000000010040UL});
    public static readonly BitSet FOLLOW_subQueryExpression_in_queryExpression543 = new BitSet(new ulong[]{0x0000000000400002UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_orderByClause_in_queryExpression558 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_querySpecification_in_subQueryExpression582 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_subQueryExpression590 = new BitSet(new ulong[]{0x0000000000010040UL});
    public static readonly BitSet FOLLOW_queryExpression_in_subQueryExpression596 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_subQueryExpression598 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectClause_in_querySpecification619 = new BitSet(new ulong[]{0x0000000004201002UL});
    public static readonly BitSet FOLLOW_fromClause_in_querySpecification630 = new BitSet(new ulong[]{0x0000000004200002UL});
    public static readonly BitSet FOLLOW_whereClause_in_querySpecification644 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_groupByClause_in_querySpecification658 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_havingClause_in_querySpecification670 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SELECT_in_selectClause694 = new BitSet(new ulong[]{0x43B80D01001E8060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_ALL_in_selectClause701 = new BitSet(new ulong[]{0x43B80D01001E8060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_DISTINCT_in_selectClause705 = new BitSet(new ulong[]{0x43B80D01001E8060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_TOP_in_selectClause714 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_Integer_in_selectClause716 = new BitSet(new ulong[]{0x43B80D01001E8060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_selectList_in_selectClause728 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHERE_in_whereClause745 = new BitSet(new ulong[]{0x43B80C2140108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_searchCondition_in_whereClause751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ORDER_in_orderByClause768 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_BY_in_orderByClause770 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_orderExpression_in_orderByClause777 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_orderByClause784 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_orderExpression_in_orderByClause790 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_expression_in_orderExpression814 = new BitSet(new ulong[]{0x0000000003000002UL});
    public static readonly BitSet FOLLOW_ASC_in_orderExpression821 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DESC_in_orderExpression825 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GROUP_in_groupByClause845 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_BY_in_groupByClause847 = new BitSet(new ulong[]{0x43B80C0100128060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_ALL_in_groupByClause855 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_groupByClause868 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_groupByClause874 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_groupByClause880 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_HAVING_in_havingClause900 = new BitSet(new ulong[]{0x43B80C2140108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_searchCondition_in_havingClause906 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveSubSearchCondition_in_searchCondition927 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_OR_in_searchCondition935 = new BitSet(new ulong[]{0x43B80C2140108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_additiveSubSearchCondition_in_searchCondition941 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_subSearchCondition_in_additiveSubSearchCondition967 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_AND_in_additiveSubSearchCondition975 = new BitSet(new ulong[]{0x43B80C2140108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_subSearchCondition_in_additiveSubSearchCondition981 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_bracketedSearchCondition1003 = new BitSet(new ulong[]{0x43B80C2140108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_searchCondition_in_bracketedSearchCondition1009 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_bracketedSearchCondition1011 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOT_in_subSearchCondition1035 = new BitSet(new ulong[]{0x43B80C2140108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_bracketedSearchCondition_in_subSearchCondition1059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_predicate_in_subSearchCondition1071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_predicate1101 = new BitSet(new ulong[]{0x0000001AC0004000UL,0x00000000000FC000UL});
    public static readonly BitSet FOLLOW_comparisonOperator_in_predicate1118 = new BitSet(new ulong[]{0x43B80CC100128060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1140 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_quantifierSpec_in_predicate1153 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_predicate1159 = new BitSet(new ulong[]{0x0000000000010040UL});
    public static readonly BitSet FOLLOW_selectStatement_in_predicate1165 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_predicate1167 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IS_in_predicate1188 = new BitSet(new ulong[]{0x0000000140000000UL});
    public static readonly BitSet FOLLOW_NOT_in_predicate1198 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_NULL_in_predicate1208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOT_in_predicate1216 = new BitSet(new ulong[]{0x0000001A00000000UL});
    public static readonly BitSet FOLLOW_LIKE_in_predicate1228 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1234 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_ESCAPE_in_predicate1249 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BETWEEN_in_predicate1273 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1279 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_AND_in_predicate1281 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IN_in_predicate1296 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_predicate1298 = new BitSet(new ulong[]{0x43B80C0100118060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_selectStatement_in_predicate1323 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_expression_in_predicate1337 = new BitSet(new ulong[]{0x0000000000002080UL});
    public static readonly BitSet FOLLOW_COMMA_in_predicate1348 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_predicate1354 = new BitSet(new ulong[]{0x0000000000002080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_predicate1367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXISTS_in_predicate1382 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_predicate1384 = new BitSet(new ulong[]{0x0000000000010040UL});
    public static readonly BitSet FOLLOW_selectStatement_in_predicate1390 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_predicate1392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ALL_in_quantifierSpec1409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SOME_in_quantifierSpec1416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ANY_in_quantifierSpec1423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectItem_in_selectList1444 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_selectList1452 = new BitSet(new ulong[]{0x43B80D01001E8060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_selectItem_in_selectList1458 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_STAR_in_selectItem1478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_alias2_in_selectItem1508 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_selectItem1514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tableColumns_in_selectItem1540 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_selectItem1553 = new BitSet(new ulong[]{0x0102000000000022UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_alias1_in_selectItem1566 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FROM_in_fromClause1589 = new BitSet(new ulong[]{0x01A00C0000000060UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tableSource_in_fromClause1595 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_COMMA_in_fromClause1602 = new BitSet(new ulong[]{0x01A00C0000000060UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tableSource_in_fromClause1608 = new BitSet(new ulong[]{0x0000000000002002UL});
    public static readonly BitSet FOLLOW_subTableSource_in_tableSource1632 = new BitSet(new ulong[]{0x0000DE0000000002UL});
    public static readonly BitSet FOLLOW_joinedTable_in_tableSource1643 = new BitSet(new ulong[]{0x0000DE0000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_subTableSource1663 = new BitSet(new ulong[]{0x01A00C0000010060UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_joinedTables_in_subTableSource1682 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_subTableSource1684 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_queryExpression_in_subTableSource1699 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_subTableSource1701 = new BitSet(new ulong[]{0x0102000000000020UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_alias1_in_subTableSource1707 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_subTableSource1742 = new BitSet(new ulong[]{0x0102000000000022UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_alias1_in_subTableSource1755 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dbObject_in_subTableSource1769 = new BitSet(new ulong[]{0x0102000000000022UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_alias1_in_subTableSource1781 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INNER_in_joinOn1803 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_LEFT_in_joinOn1810 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_RIGHT_in_joinOn1818 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_FULL_in_joinOn1826 = new BitSet(new ulong[]{0x0000600000000000UL});
    public static readonly BitSet FOLLOW_OUTER_in_joinOn1836 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_JOIN_in_joinOn1846 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CROSS_in_joinedTable1861 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_JOIN_in_joinedTable1863 = new BitSet(new ulong[]{0x01A00C0000000060UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_subTableSource_in_joinedTable1869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_joinOn_in_joinedTable1884 = new BitSet(new ulong[]{0x01A00C0000000060UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_tableSource_in_joinedTable1893 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_ON_in_joinedTable1900 = new BitSet(new ulong[]{0x43B80C2140108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_searchCondition_in_joinedTable1906 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_subTableSource_in_joinedTables1931 = new BitSet(new ulong[]{0x0000DE0000000000UL});
    public static readonly BitSet FOLLOW_joinedTable_in_joinedTables1943 = new BitSet(new ulong[]{0x0000DE0000000002UL});
    public static readonly BitSet FOLLOW_AS_in_alias11966 = new BitSet(new ulong[]{0x0100000000000020UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_identifier_in_alias11974 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_identifier_in_alias21995 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ASSIGNEQUAL_in_alias22001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dbObject_in_tableColumns2020 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_DOT_STAR_in_tableColumns2022 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dbObject_in_column2044 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LPAREN_in_column2053 = new BitSet(new ulong[]{0x0100000000000060UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_column_in_column2059 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_column2061 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveSubExpression_in_expression2082 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000E00UL});
    public static readonly BitSet FOLLOW_additiveOperator_in_expression2093 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_additiveSubExpression_in_expression2099 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000E00UL});
    public static readonly BitSet FOLLOW_subExpression_in_additiveSubExpression2124 = new BitSet(new ulong[]{0x0000010000000002UL,0x0000000000003000UL});
    public static readonly BitSet FOLLOW_multiplicativeArithmeticOperator_in_additiveSubExpression2135 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_subExpression_in_additiveSubExpression2141 = new BitSet(new ulong[]{0x0000010000000002UL,0x0000000000003000UL});
    public static readonly BitSet FOLLOW_LPAREN_in_bracketedTerm2161 = new BitSet(new ulong[]{0x43B80C0100118060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_selectStatement_in_bracketedTerm2179 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_bracketedTerm2181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_bracketedTerm2193 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_bracketedTerm2195 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryOperator_in_subExpression2220 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_constant_in_subExpression2235 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableReference_in_subExpression2247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLACEHOLDER_in_subExpression2255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_subExpression2276 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracketedTerm_in_subExpression2288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_dbObject_in_subExpression2300 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_caseFunction_in_subExpression2346 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castFunction_in_subExpression2358 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Variable_in_variableReference2377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SUBSTRING_in_function2395 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_function2399 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_function2405 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_FROM_in_function2409 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_function2415 = new BitSet(new ulong[]{0x0040000000000080UL});
    public static readonly BitSet FOLLOW_FOR_in_function2421 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_function2427 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_function2434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXTRACT_in_function2439 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_function2441 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000007E00000UL});
    public static readonly BitSet FOLLOW_datetimeField_in_function2447 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_FROM_in_function2449 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_function2455 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_function2459 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_genericFunction_in_function2468 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NonQuotedIdentifier_in_genericFunction2497 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LEFT_in_genericFunction2505 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_RIGHT_in_genericFunction2513 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_genericFunction2520 = new BitSet(new ulong[]{0x43B80D01001680E0UL,0x0000000007E007FFUL});
    public static readonly BitSet FOLLOW_functionArgument_in_genericFunction2530 = new BitSet(new ulong[]{0x0000000000002080UL});
    public static readonly BitSet FOLLOW_COMMA_in_genericFunction2539 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x0000000007E007FFUL});
    public static readonly BitSet FOLLOW_functionArgument_in_genericFunction2545 = new BitSet(new ulong[]{0x0000000000002080UL});
    public static readonly BitSet FOLLOW_STAR_in_genericFunction2562 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_ALL_in_genericFunction2578 = new BitSet(new ulong[]{0x43B80D0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_DISTINCT_in_genericFunction2582 = new BitSet(new ulong[]{0x43B80D0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_STAR_in_genericFunction2593 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_expression_in_genericFunction2610 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_genericFunction2632 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_functionArgument2651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_datetimeField_in_functionArgument2662 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_caseFunction2679 = new BitSet(new ulong[]{0x47B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_caseFunction2691 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_WHEN_in_caseFunction2700 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_caseFunction2706 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_THEN_in_caseFunction2708 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_caseFunction2714 = new BitSet(new ulong[]{0x3400000000000000UL});
    public static readonly BitSet FOLLOW_WHEN_in_caseFunction2735 = new BitSet(new ulong[]{0x43B80C2140108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_searchCondition_in_caseFunction2741 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_THEN_in_caseFunction2743 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_caseFunction2749 = new BitSet(new ulong[]{0x3400000000000000UL});
    public static readonly BitSet FOLLOW_ELSE_in_caseFunction2770 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_caseFunction2776 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_END_in_caseFunction2783 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_CASE_in_caseFunction2787 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CAST_in_castFunction2806 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_LPAREN_in_castFunction2808 = new BitSet(new ulong[]{0x43B80C0100108060UL,0x00000000000007FFUL});
    public static readonly BitSet FOLLOW_expression_in_castFunction2814 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_AS_in_castFunction2816 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_typeIdentifier_in_castFunction2822 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_LPAREN_in_castFunction2830 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_nonNegativeInteger_in_castFunction2836 = new BitSet(new ulong[]{0x0000000000002080UL});
    public static readonly BitSet FOLLOW_COMMA_in_castFunction2842 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_nonNegativeInteger_in_castFunction2848 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_castFunction2855 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_castFunction2860 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_identifier_in_dbObject2879 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_DOT_in_dbObject2886 = new BitSet(new ulong[]{0x0100000000000020UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_identifier_in_dbObject2892 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_singleStringLiteral_in_stringLiteral2920 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_singleStringLiteral_in_stringLiteral2930 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_UnicodeStringLiteral_in_singleStringLiteral2950 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AsciiStringLiteral_in_singleStringLiteral2957 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NonQuotedIdentifier_in_identifier2974 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_QuotedIdentifier_in_identifier2981 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NonQuotedIdentifier_in_typeIdentifier2998 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonNegativeInteger_in_constant3019 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Real_in_constant3026 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_in_constant3033 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringLiteral_in_constant3044 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_intervalLiteral_in_constant3055 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_HexLiteral_in_constant3062 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MAccessDateTime_in_constant3071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Iso8601DateTime_in_constant3080 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TIMESTAMP_in_constant3087 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_stringLiteral_in_constant3093 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTERVAL_in_intervalLiteral3117 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000602UL});
    public static readonly BitSet FOLLOW_unaryOperator_in_intervalLiteral3125 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AsciiStringLiteral_in_intervalLiteral3132 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000007E00000UL});
    public static readonly BitSet FOLLOW_datetimeField_in_intervalLiteral3140 = new BitSet(new ulong[]{0x0000000000000042UL});
    public static readonly BitSet FOLLOW_LPAREN_in_intervalLiteral3146 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_Integer_in_intervalLiteral3148 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RPAREN_in_intervalLiteral3152 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Integer_in_nonNegativeInteger3170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_unaryOperator3187 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_unaryOperator3194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_additiveOperator3211 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_additiveOperator3218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRCONCAT_in_additiveOperator3225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STAR_in_multiplicativeArithmeticOperator3246 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DIVIDE_in_multiplicativeArithmeticOperator3253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MOD_in_multiplicativeArithmeticOperator3260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGNEQUAL_in_comparisonOperator3281 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOTEQUAL1_in_comparisonOperator3288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOTEQUAL2_in_comparisonOperator3295 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LESSTHANOREQUALTO1_in_comparisonOperator3302 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LESSTHAN_in_comparisonOperator3309 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GREATERTHANOREQUALTO1_in_comparisonOperator3316 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_GREATERTHAN_in_comparisonOperator3323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UNION_in_unionOperator3340 = new BitSet(new ulong[]{0x0000000000020002UL});
    public static readonly BitSet FOLLOW_ALL_in_unionOperator3347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_YEAR_in_datetimeField3367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MONTH_in_datetimeField3374 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DAY_in_datetimeField3381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_HOUR_in_datetimeField3388 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUTE_in_datetimeField3395 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SECOND_in_datetimeField3402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bracketedSearchCondition_in_synpred1_MacroScope1047 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectStatement_in_synpred2_MacroScope1308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_alias2_in_synpred3_MacroScope1494 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tableColumns_in_synpred4_MacroScope1531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_joinedTables_in_synpred5_MacroScope1670 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_synpred6_MacroScope1731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selectStatement_in_synpred7_MacroScope2166 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_function_in_synpred8_MacroScope2264 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}