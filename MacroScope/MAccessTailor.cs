using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MacroScope
{
    /// <summary>
    /// SQL for MS Access.
    /// </summary>
    public class MAccessTailor : MTailor
    {
        #region Fields

        /// <summary>
        /// Datetime units for MS Access DATEADD function.
        /// </summary>
        /// <remarks>
        /// Lazily initialized.
        /// </remarks>
        private Dictionary<DateTimeUnit, string> m_intervals;

        /// <summary>
        /// Variables (canonicalized, i.e. without prefix) to be interpolated.
        /// </summary>
        private readonly Dictionary<string, DateTime> m_dates;

        private Dictionary<string, AliasedItem> m_selectItemAliases;

        private int m_inFromClause;

        private bool m_inSelectItems;

        #endregion

        #region Constructor

        public MAccessTailor():
            base(ExpressionOperator.MAccessMod)
        {
            m_dates = new Dictionary<string, DateTime>();
            m_inFromClause = 0;
        }

        #endregion

        #region MAccessTailor-specific settings

        public void AddDate(string paramName, DateTime paramValue)
        {
            if (paramName == null)
            {
                throw new ArgumentNullException("paramName");
            }

            string key = Variable.Canonicalize(paramName);
            if (m_dates.ContainsKey(key))
            {
                string message = string.Format("{0} date was already specified.",
                    paramName);
                throw new InvalidOperationException(message);
            }

            m_dates.Add(key, paramValue);
        }

        #endregion

        #region IVisitor Members

        public override void PerformBefore(AliasedItem node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.PerformBefore(node);

            if (m_inFromClause > 0)
            {
                ChopCrossJoins(node);
                BracketJoinConditions(node);
                ChopJoinChains(node);
            }

            if (m_inSelectItems)
            {
                Debug.Assert(m_selectItemAliases != null);

                Identifier alias = node.Alias;
                if (alias != null)
                {
                    string key = Identifier.Canonicalize(alias.ID);
                    if (m_selectItemAliases.ContainsKey(key))
                    {
                        string message = string.Format("Duplicate output alias {0}.",
                            alias.ID);
                        throw new InvalidOperationException(message);
                    }

                    m_selectItemAliases.Add(key, node);
                }
            }
        }

        public override void PerformBefore(CaseExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            ReplaceTerm(node, MakeSwitch(node));

            base.PerformBefore(node);
        }

        public override void PerformBefore(DbObject node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (!node.HasNext)
            {
                if (TailorUtil.IsSysdate(node.Identifier))
                {
                    ReplaceTerm(node, new FunctionCall(
                        TailorUtil.GetCapitalized(TailorUtil.NOW)));
                }

                if (!m_inSelectItems && (m_selectItemAliases != null))
                {
                    string key = Identifier.Canonicalize(node.Identifier.ID);
                    if (m_selectItemAliases.ContainsKey(key))
                    {
                        AliasedItem orig = m_selectItemAliases[key];
                        ReplaceTerm(node, orig.Item.Clone());
                    }
                }
            }

            base.PerformBefore(node);
        }

        public override void Perform(DefaultValue node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.Perform(node);

            throw new InvalidOperationException(
                "MS Access cannot update to default value.");
        }

        public override void Perform(ExpressionOperator node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.Perform(node);

            if (node == ExpressionOperator.Mod)
            {
                Expression parent = Parent as Expression;
                if (parent != null)
                {
                    parent.Operator = ExpressionOperator.MAccessMod;
                }
                else
                {
                    throw new InvalidOperationException("Modulo operator not in expression.");
                }
            }
            else if (node == ExpressionOperator.StrConcat)
            {
                Expression parent = Parent as Expression;
                if (parent != null)
                {
                    parent.Operator = ExpressionOperator.Plus; // '&' also works
                }
                else
                {
                    throw new InvalidOperationException(
                        "String concatenation operator not in expression.");
                }
            }
        }

        public override void PerformAfter(ExtractFunction node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.PerformAfter(node);

            ReplaceTerm(node, MakeDateExtractor(node));
        }

        public override void PerformBefore(FunctionCall node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.PerformBefore(node);

            string name = node.Name.ToLowerInvariant();
            if (name.Equals(TailorUtil.GETDATE))
            {
                node.Name = TailorUtil.GetCapitalized(TailorUtil.NOW);
            }
            else if (name.Equals(TailorUtil.COALESCE))
            {
                CoalesceToIif(node);
            }
        }

        public override void PerformAfter(FunctionCall node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.PerformAfter(node);

            if (TailorUtil.SUBSTRING.Equals(node.Name.ToLowerInvariant()))
            {
                ReplaceTerm(node, MakeSubstring(node));
            }
        }

        public override void Perform(Identifier node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.Perform(node);

            node.NormalizeQuotes('`');
        }

        public override void PerformBefore(InsertStatement node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.ColumnNames == null)
            {
                throw new InvalidOperationException("Insert has no names.");
            }

            bool shaving = true;
            while (shaving)
            {
                ExpressionItem headValue = node.ColumnValues;
                if (headValue == null)
                {
                    throw new InvalidOperationException(
                        "Insert statement has too few values.");
                }

                if (headValue.Expression.Equals(DefaultValue.Value))
                {
                    AliasedItem headColumn = node.ColumnNames.Next;
                    if (headColumn == null)
                    {
                        throw new InvalidOperationException(
                            "MS Access cannot insert only default values.");
                    }

                    node.ColumnNames = headColumn;
                    node.ColumnValues = headValue.Next;
                }
                else
                {
                    shaving = false;
                }
            }

            AliasedItem tailColumn = node.ColumnNames;
            ExpressionItem tailValue = node.ColumnValues;
            while (tailColumn.Next != null)
            {
                if (tailValue.Next == null)
                {
                    throw new InvalidOperationException("Insert has too few values.");
                }

                if (tailValue.Next.Expression.Equals(DefaultValue.Value))
                {
                    tailColumn.Next = tailColumn.Next.Next;
                    tailValue.Next = tailValue.Next.Next;
                }
                else
                {
                    tailColumn = tailColumn.Next;
                    tailValue = tailValue.Next;
                }
            }

            base.PerformBefore(node);
        }

        public override void Perform(LiteralDateTime node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.Perform(node);

            node.Delimiter = '#';
        }

        public override void PerformBefore(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.PerformBefore(node);

            m_inSelectItems = true;
            m_selectItemAliases = new Dictionary<string, AliasedItem>();
        }

        public override void PerformOnFrom(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_inSelectItems = false;
            base.PerformOnFrom(node);

            ++m_inFromClause;
        }

        public override void PerformOnWhere(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.PerformOnWhere(node);

            if (m_inFromClause <= 0)
            {
                throw new InvalidOperationException(
                    "PerformOnFrom must be called before PerformOnWhere.");
            }

            --m_inFromClause;
        }

        public override void PerformAfter(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            m_selectItemAliases = null;

            base.PerformAfter(node);
        }

        public override void Perform(StringValue node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (node.QuoteType == 'n')
            {
                node.QuoteType = '\"';
            }

            base.Perform(node);
        }

        public override void Perform(Variable node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.Perform(node);

            string key = Variable.Canonicalize(node.PrefixedName);
            Debug.Assert(key != null);
            if (m_dates.ContainsKey(key))
            {
                LiteralDateTime literalDateTime = new LiteralDateTime(m_dates[key]);
                literalDateTime.Delimiter = '#';
                ReplaceTerm(node, literalDateTime);
            }
        }

        #endregion

        #region Transformations

        protected override FunctionCall GetDateaddCall(DateTimeUnit unit,
            INode number, INode date)
        {
            if (unit == null)
            {
                throw new ArgumentNullException("unit");
            }

            if (number == null)
            {
                throw new ArgumentNullException("number");
            }

            if (date == null)
            {
                throw new ArgumentNullException("date");
            }

            if (unit == DateTimeUnit.Month)
            {
                throw new ArgumentNullException("Standard month arithmetic not supported.");
            }

            if (m_intervals == null)
            {
                m_intervals = new Dictionary<DateTimeUnit, string>();
                m_intervals.Add(DateTimeUnit.Year, "yyyy");
                m_intervals.Add(DateTimeUnit.Month, "m");
                m_intervals.Add(DateTimeUnit.Day, "d");
                m_intervals.Add(DateTimeUnit.Hour, "h");
                m_intervals.Add(DateTimeUnit.Minute, "n");
                m_intervals.Add(DateTimeUnit.Second, "s");
            }

            FunctionCall dateadd = new FunctionCall(TailorUtil.DATEADD.ToUpperInvariant());

            StringValue stringValue = new StringValue(m_intervals[unit]);
            stringValue.QuoteType = '\"';
            dateadd.ExpressionArguments = new ExpressionItem(stringValue);
            dateadd.ExpressionArguments.Add(new ExpressionItem(number));
            dateadd.ExpressionArguments.Add(new ExpressionItem(date));
            return dateadd;
        }

        INode MakeSubstring(FunctionCall substringCall)
        {
            if (substringCall == null)
            {
                throw new ArgumentNullException("substringCall");
            }

            substringCall.Name = TailorUtil.GetCapitalized(TailorUtil.MID);

            ExpressionItem val = substringCall.ExpressionArguments;
            if (val == null)
            {
                throw new InvalidOperationException("No parameters for SUBSTRING.");
            }

            ExpressionItem start = val.Next;
            if (start == null)
            {
                throw new InvalidOperationException("Too few parameters for SUBSTRING.");
            }

            ExpressionItem len = start.Next;

            INode cond = MakeNotNullCheck(start);   // Mid actually handles NULL
                                                    // in the first parameter

            if (len == null)
            {
                // We don't need to add length in the normal case, but it's
                // useful when the start position is too large and the call
                // ought to fail (which Mid doesn't, unless it's called with
                // a negative length).
                IExpression argument = TailorUtil.MakeLenArg(start.Expression,
                    val.Expression, "Len");
                start.Add(new ExpressionItem(argument));
            }
            else
            {
                if (len.Next != null)
                {
                    throw new InvalidOperationException("Too many parameters for SUBSTRING.");
                }
            }

            if (cond == null)
            {
                return substringCall;
            }
            else
            {
                FunctionCall iifCall = new FunctionCall("Iif");
                iifCall.ExpressionArguments = new ExpressionItem(cond);
                iifCall.ExpressionArguments.Add(new ExpressionItem(NullValue.Value));
                iifCall.ExpressionArguments.Add(new ExpressionItem(substringCall));
                return iifCall;
            }
        }

        FunctionCall MakeDateExtractor(
            ExtractFunction extractFunction)
        {
            if (extractFunction == null)
            {
                throw new ArgumentNullException("extractFunction");
            }

            FunctionCall functionCall = new FunctionCall(extractFunction.FieldSpec.Value);
            functionCall.ExpressionArguments = new ExpressionItem(extractFunction.Source);
            return functionCall;
        }

        static INode MakeNotNullCheck(ExpressionItem list)
        {
            INode top = null;

            while (list != null)
            {
                INode term = TailorUtil.GetTerm(list.Expression);
                IntegerValue integerValue = term as IntegerValue;
                if (integerValue == null)
                {
                    FunctionCall leaf = new FunctionCall("IsNull");
                    leaf.ExpressionArguments = new ExpressionItem(term.Clone());

                    if (top == null)
                    {
                        top = leaf;
                    }
                    else
                    {
                        top = new Expression(top, ExpressionOperator.Or, leaf);
                    }
                }

                list = list.Next;
            }

            return top;
        }

        void CoalesceToIif(FunctionCall coalesce)
        {
            ExpressionItem args = coalesce.ExpressionArguments;
            if (args == null)
            {
                throw new InvalidOperationException("COALESCE has no arguments.");
            }

            if (args.Next == null)
            {
                throw new InvalidOperationException("COALESCE has just one argument.");
            }

            FunctionCall iif = (FunctionCall)MakeIif(args);
            coalesce.Name = iif.Name;
            coalesce.ExpressionArguments = iif.ExpressionArguments;
        }

        INode MakeIif(ExpressionItem args)
        {
            if (args == null)
            {
                throw new ArgumentNullException("args");
            }

            ExpressionItem tail = args.Next;
            if (tail == null)
            {
                return args.Expression;
            }
            else
            {
                INode current = args.Expression;

                FunctionCall testArg = new FunctionCall("IsNull");
                testArg.ExpressionArguments = new ExpressionItem(current.Clone());

                FunctionCall outer = new FunctionCall("Iif");
                outer.ExpressionArguments = new ExpressionItem(testArg);
                outer.ExpressionArguments.Add(
                    new ExpressionItem(MakeIif(tail)));
                outer.ExpressionArguments.Add(new ExpressionItem(current));

                return outer;
            }
        }

        SwitchFunction MakeSwitch(CaseExpression caseExpr)
        {
            if (caseExpr == null)
            {
                throw new ArgumentNullException("caseExpr");
            }

            IExpression left = caseExpr.Case;
            SwitchFunction switchFunc = new SwitchFunction();

            CaseAlternative alt = caseExpr.Alternatives;
            if (alt == null)
            {
                throw new InvalidOperationException("CASE has no alternatives.");
            }

            // branch expressions will be tailored through caseExpr.Alternatives

            if (left != null)
            {
                while (alt != null)
                {
                    alt.When = new Expression(left.Clone(), ExpressionOperator.Equal,
                        alt.When);

                    CaseAlternative next = alt.Next;
                    alt.Next = null;
                    switchFunc.Add(alt);

                    alt = next;
                }
            }
            else
            {
                switchFunc.Alternatives = alt;
            }

            IExpression elseExpr = caseExpr.Else;
            if (elseExpr != null)
            {
                // elseExpr will be tailored through caseExpr.Else

                CaseAlternative last = new CaseAlternative(
                    new Expression(
                        new IntegerValue(1),
                        ExpressionOperator.Equal,
                        new IntegerValue(1)),
                    elseExpr);
                switchFunc.Add(last);
            }

            return switchFunc;
        }

        static void ChopCrossJoins(AliasedItem node)
        {
            Table head = GetHead(node);

            AliasedItem current = node;
            Table prev = head;
            while (prev.Next != null)
            {
                Table next = prev.Next;
                if (next.JoinType == Join.Cross)
                {
                    if (next.JoinCondition != null)
                    {
                        throw new InvalidOperationException(
                            "Cross join with join condition.");
                    }

                    next.JoinType = null;

                    prev.Next = null;
                    AliasedItem splice = new AliasedItem(next);
                    splice.Next = current.Next;
                    current.Next = splice;
                    current = splice;
                }

                prev = next;
            }
        }

        static void ChopJoinChains(AliasedItem node)
        {
            Table head = GetHead(node);
            Table next = head.Next;
            while (next != null)
            {
                Table tail = next.Next;
                if (tail != null)
                {
                    next.Next = null;
                    BracketedExpression expr = new BracketedExpression(head);
                    head = new Table(expr);
                    head.Next = tail;
                }

                next = tail;
            }

            node.Item = head;
        }

        static void BracketJoinConditions(AliasedItem node)
        {
            Table table = GetHead(node);
            while (table != null)
            {
                IExpression cond = table.JoinCondition;
                if ((cond != null) && !(cond is BracketedExpression))
                {
                    table.JoinCondition = new BracketedExpression(cond);
                }

                table = table.Next;
            }
        }

        static Table GetHead(AliasedItem node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            Table head = node.Item as Table;
            if (head == null)
            {
                throw new InvalidOperationException(
                    "FROM clause can contain only Table items.");
            }

            return head;
        }

        #endregion
    }
}
