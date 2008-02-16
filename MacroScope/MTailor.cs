using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MacroScope
{
    /// <summary>
    /// Common transformations for <see cref="MSqlServerTailor"/>
    /// and <see cref="MAccessTailor"/>.
    /// </summary>
    public abstract class MTailor : TracingVisitor
    {
        #region Fields

        private Namer m_namer;

        private readonly ExpressionOperator m_modOp;

        #endregion

        #region Constructor

        public MTailor(ExpressionOperator modOp)
        {
            if (modOp == null)
            {
                throw new ArgumentNullException("modOp");
            }

            m_modOp = modOp;
        }

        #endregion

        #region Properties

        public Namer Namer
        {
            get
            {
                if (m_namer == null)
                {
                    m_namer = new Namer('@');
                }

                return m_namer;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                m_namer = value;
            }
        }

        #endregion

        #region IVisitor Members

        public override void PerformBefore(Expression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.PerformBefore(node);

            Namer.PerformBefore(node);
        }

        public override void PerformAfter(FunctionCall node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.PerformAfter(node);

            if (TailorUtil.MOD.Equals(node.Name.ToLowerInvariant()))
            {
                ReplaceTerm(node, MakeModCall(node));
            }
        }

        public override void PerformBefore(Interval node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            ReplaceIntervals(null);

            base.PerformBefore(node);
        }

        public override void Perform(Identifier node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.Perform(node);

            if (IsRownum(node))
            {
                int limit = 0;

                QueryExpression query = GetAncestor<QueryExpression>(null, null);
                if (query != null)
                {
                    Expression relational = GetExpressionAncestor(null, query);
                    if (relational != null)
                    {
                        limit = GetRownumExpressionLimit(relational);
                        if (limit > 0)
                        {
                            bool matched = false;

                            Expression logical = GetExpressionAncestor(relational, query);
                            if (logical == null)
                            {
                                if (query.Where == relational)
                                {
                                    query.Where = null;
                                    matched = true;
                                }
                            }
                            else
                            {
                                if (logical.Operator == ExpressionOperator.And)
                                {
                                    if (relational == logical.Left)
                                    {
                                        logical.Operator = null;
                                        logical.Left = null;
                                        matched = true;
                                    }
                                    else if (relational == logical.Right)
                                    {
                                        logical.Operator = null;
                                        logical.Right = null;
                                        matched = true;
                                    }
                                }
                            }

                            if (matched)
                            {
                                SetTop(query, limit);
                            }
                            else
                            {
                                limit = -1;
                            }
                        }
                    }
                }

                if (limit <= 0)
                {
                    throw new InvalidOperationException(
                        "MS engines do not have ROWNUM.");
                }
            }
        }

        public override void PerformBefore(QueryExpression node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.PerformBefore(node);

            if (node.Where == null)
            {
                AliasedItem from = node.From;
                if ((from != null) && (from.Alias == null) && !from.HasNext)
                {
                    Table singleTable = from.Item as Table;
                    if ((singleTable != null) && (singleTable.Alias == null) &&
                        (singleTable.JoinCondition == null) &&
                        (singleTable.JoinType == null) && !singleTable.HasNext)
                    {                        
                        DbObject singleName = TailorUtil.GetTerm(
                            singleTable.Source) as DbObject;
                        if ((singleName != null) && !singleName.HasNext)
                        {
                            Identifier identifier = singleName.Identifier;

                            // Not canonicalizing - we're accepting quoted "dual"
                            // as a regular identifier.
                            if (TailorUtil.DUAL.Equals(
                                identifier.ID.ToLowerInvariant()))
                            {
                                node.From = null;
                            }
                        }
                    }
                }
            }
        }

        public override void Perform(Variable node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.Perform(node);

            node.Prefix = '@';
        }

        #endregion

        #region Transformations

        protected abstract FunctionCall GetDateaddCall(DateTimeUnit unit,
            INode number, INode date);

        static void SetTop(QueryExpression query, int limit)
        {
            if (query == null)
            {
                throw new ArgumentNullException("query");
            }

            if (limit <= 0)
            {
                throw new ArgumentOutOfRangeException("limit");
            }

            if (query.Top == null)
            {
                query.Top = limit;
            }
            else
            {
                query.Top = Math.Min((int)(query.Top), limit);
            }
        }

        void ReplaceIntervals(Expression done)
        {
            Expression node = GetExpressionParent(done);
            if (node == null)
            {
                return;
            }

            Interval leftInterval = GetInterval(node.Left);
            Interval rightInterval = GetInterval(node.Right);

            if (leftInterval != null)
            {
                if (rightInterval != null)
                {
                    ReplaceBothIntervals(node, leftInterval, rightInterval);
                }
                else
                {
                    ReplaceLeftInterval(node, leftInterval);
                }
            }
            else if (rightInterval != null)
            {
                ReplaceRightInterval(node, rightInterval);
            }
        }

        void ReplaceBothIntervals(Expression node, Interval leftInterval,
            Interval rightInterval)
        {
            if (leftInterval.DateTimeUnit != rightInterval.DateTimeUnit)
            {
                throw new InvalidOperationException(
                    "Can't combine intervals with different units.");
                // well, technically we could (at least for some units), but nobody
                // needed that yet
            }

            if ((node.Operator != ExpressionOperator.Plus) &&
                (node.Operator != ExpressionOperator.Minus))
            {
                throw new InvalidOperationException("Can't multiply intervals.");
            }

            node.Left = new Interval(
                new Expression(leftInterval.GetSignedValue(),
                    node.Operator,
                    rightInterval.GetSignedValue()),
                leftInterval.DateTimeUnit);
            node.Operator = null;
            node.Right = null;

            ReplaceIntervals(node);
        }

        void ReplaceLeftInterval(Expression node, Interval leftInterval)
        {
            if (node.Operator == ExpressionOperator.Plus)
            {
                // base date hasn't been tailored yet - keep it in the future
                // of this traversal
                node.Right = GetDateaddCall(leftInterval.DateTimeUnit,
                    leftInterval.GetSignedValue(),
                    node.Right);
                node.Operator = null;
                node.Left = null;
            }
            else if ((node.Operator == ExpressionOperator.Mult) ||
                (node.Operator == ExpressionOperator.Div))
            {
                // base date hasn't been tailored yet - keep it in the future
                // of this traversal
                node.Right = new Interval(
                    GetMultipliedInterval(leftInterval,
                        node.Right,
                        node.Operator),
                    leftInterval.DateTimeUnit);
                node.Operator = null;
                node.Left = null;

                ReplaceIntervals(node);
            }
            else
            {
                throw new InvalidOperationException(
                    "Subtraction from interval not supported.");
            }
        }

        void ReplaceRightInterval(Expression node, Interval rightInterval)
        {
            if (node.Operator == ExpressionOperator.Plus)
            {
                // base date hasn't been tailored yet - keep it in the future
                // of this traversal
                node.Right = GetDateaddCall(rightInterval.DateTimeUnit,
                    rightInterval.GetSignedValue(),
                    node.Left);
                node.Operator = null;
                node.Left = null;
            }
            else if (node.Operator == ExpressionOperator.Minus)
            {
                Interval negativeInterval = (Interval)(rightInterval.Clone());
                negativeInterval.Positive = !negativeInterval.Positive;

                // base date hasn't been tailored yet - keep it in the future
                // of this traversal
                node.Right = GetDateaddCall(negativeInterval.DateTimeUnit,
                    negativeInterval.GetSignedValue(),
                    node.Left);
                node.Operator = null;
                node.Left = null;
            }
            else if (node.Operator == ExpressionOperator.Mult)
            {
                // base date hasn't been tailored yet - keep it in the future
                // of this traversal
                node.Right = new Interval(
                    GetMultipliedInterval(rightInterval,
                        node.Left,
                        ExpressionOperator.Mult),
                    rightInterval.DateTimeUnit);
                node.Operator = null;
                node.Left = null;

                ReplaceIntervals(node);
            }
            else
            {
                throw new InvalidOperationException(
                    "Division by interval not supported.");
            }
        }

        static INode GetMultipliedInterval(Interval interval,
            INode multiplier, ExpressionOperator op)
        {
            if (interval == null)
            {
                throw new ArgumentNullException("interval");
            }

            if (multiplier == null)
            {
                throw new ArgumentNullException("multiplier");
            }

            if (op == null)
            {
                throw new ArgumentNullException("op");
            }

            INode inner = interval.GetSignedValue();
            IntegerValue integerValue = inner as IntegerValue;
            INode newValue;
            if ((integerValue != null) &&
                (integerValue.Value == 1))
            {
                newValue = multiplier;
            }
            else
            {
                newValue = new Expression(inner, op, multiplier);
            }

            return newValue;
        }

        /// <summary>
        /// Finds a non-trivial (i.e. having an operator) expression.
        /// </summary>
        /// <param name="child">
        /// If not null, the found expression is the first
        /// ancestor of <paramref name="child"/>, otherwise
        /// it's the newest expression on the ancestor stack.
        /// </param>
        /// <returns>
        /// An ancestor <see cref="Expression"/>, or (when there isn't any)
        /// null.
        /// </returns>
        Expression GetExpressionParent(Expression child)
        {
            Expression expr = GetParent(child) as Expression;
            while ((expr != null) && (expr.Operator == null))
            {
                expr = GetParent(expr) as Expression;
            }

            return expr;
        }

        Expression GetExpressionAncestor(Expression child, INode parent)
        {
            Expression expr = GetAncestor<Expression>(child, parent);
            while ((expr != null) && (expr.Operator == null))
            {
                expr = GetAncestor<Expression>(expr, parent);
            }

            return expr;
        }

        Expression MakeModCall(FunctionCall functionCall)
        {
            if (functionCall == null)
            {
                throw new ArgumentNullException("functionCall");
            }

            ExpressionItem head = functionCall.ExpressionArguments;
            if (head == null)
            {
                throw new InvalidOperationException("MOD has no arguments.");
            }

            ExpressionItem next = head.Next;
            if (next == null)
            {
                throw new InvalidOperationException("MOD has only one argument.");
            }

            if (next.Next != null)
            {
                throw new InvalidOperationException("MOD has too many arguments.");
            }

            return new Expression(head.Expression,
                m_modOp,
                next.Expression);
        }

        static Interval GetInterval(INode arg)
        {
            Expression expr = arg as Expression;
            while ((expr != null) && (expr.Operator == null))
            {
                arg = (expr.Left != null) ? expr.Left : expr.Right;
                expr = arg as Expression;
            }

            return arg as Interval;
        }

        int GetRownumExpressionLimit(Expression expr)
        {
            if (expr == null)
            {
                throw new ArgumentNullException("expr");
            }

            decimal limit = -1;
            if (expr.Operator == ExpressionOperator.LessOrEqual)
            {
                if (IsRownumTerm(expr.Left))
                {
                    limit = GetTermLimit(expr.Right);
                }
            }
            else if (expr.Operator == ExpressionOperator.Less)
            {
                if (IsRownumTerm(expr.Left))
                {
                    limit = GetSharpTermLimit(expr.Right);
                }
            }
            else if (expr.Operator == ExpressionOperator.GreaterOrEqual)
            {
                if (IsRownumTerm(expr.Right))
                {
                    limit = GetTermLimit(expr.Left);
                }
            }
            else if (expr.Operator == ExpressionOperator.Greater)
            {
                if (IsRownumTerm(expr.Right))
                {
                    limit = GetSharpTermLimit(expr.Left);
                }
            }

            int ilimit = (int)limit;
            if (limit != ilimit)
            {
                string message = string.Format("TOP argument {0} too large.",
                    limit);
                throw new Exception(message);
            }

            return ilimit;
        }

        static decimal GetSharpTermLimit(INode arg)
        {
            decimal limit = GetTermLimit(arg);
            if (limit > 0)
            {
                --limit;
            }

            return limit;
        }

        static decimal GetTermLimit(INode arg)
        {
            arg = GetComparedTerm(arg);

            IntegerValue iv = arg as IntegerValue;
            if (iv == null)
            {
                return -1;
            }

            return iv.Value;
        }

        static bool IsRownumTerm(INode arg)
        {
            arg = GetComparedTerm(arg);

            DbObject dbObject = arg as DbObject;
            if ((dbObject == null) || dbObject.HasNext)
            {
                return false;
            }

            return IsRownum(dbObject.Identifier);
        }

        static INode GetComparedTerm(INode arg)
        {
            if (arg == null)
            {
                throw new InvalidOperationException(
                    "Comparison operator missing argument.");
            }

            return TailorUtil.GetTerm(arg);
        }

        /// <summary>
        /// Test for unquoted <see cref="TailorUtil.ROWNUM"/>.
        /// </summary>
        /// <remarks>
        /// Not canonicalizing - we're accepting quoted "rownum"
        /// as a regular identifier.
        /// </remarks>
        static bool IsRownum(Identifier identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            return TailorUtil.ROWNUM.Equals(
                identifier.ID.ToLowerInvariant());
        }

        #endregion
    }
}
