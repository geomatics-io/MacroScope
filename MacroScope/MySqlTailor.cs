using System;

namespace MacroScope
{
    /// <summary>
    /// SQL for MySQL.
    /// </summary>
    /// <remarks>
    /// MySQL sometimes doesn't report errors the standard requires (i.e. on division by zero,
    /// or invalid date arithmetic). When using this tailor, some queries which should
    /// have failed may instead return null.
    /// </remarks>
    public class MySqlTailor : TracingVisitor
    {
        #region Fields

        private Namer m_namer;

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

        public override void PerformBefore(DbObject node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (!node.HasNext && TailorUtil.IsSysdate(node.Identifier))
            {
                ReplaceTerm(node, new DbObject(new Identifier(
                    TailorUtil.CURRENT_TIMESTAMP.ToUpperInvariant())));
            }

            base.PerformBefore(node);
        }

        public override void Perform(ExpressionOperator node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.Perform(node);

            if (node == ExpressionOperator.StrConcat)
            {
                Expression parent = Parent as Expression;
                if ((parent != null) && (parent.Left != null) && (parent.Right != null))
                {
                    FunctionCall concat = new FunctionCall(TailorUtil.CONCAT.ToUpperInvariant());
                    concat.ExpressionArguments = new ExpressionItem(parent.Left);
                    concat.ExpressionArguments.Add(new ExpressionItem(parent.Right));

                    parent.Operator = null;
                    parent.Left = concat;
                    parent.Right = null;
                }
                else
                {
                    throw new InvalidOperationException(
                        "String concatenation operator is not in expression.");
                }
            }
        }

        public override void PerformBefore(FunctionCall node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            string name = node.Name.ToLowerInvariant();
            if (name.Equals(TailorUtil.GETDATE))
            {
                ReplaceTerm(node, new DbObject(new Identifier(
                    TailorUtil.CURRENT_TIMESTAMP.ToUpperInvariant())));
            }

            base.PerformBefore(node);
        }

        public override void Perform(Identifier node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.Perform(node);

            if (TailorUtil.IsRownum(node))
            {
                int limit = 0;

                QueryExpression query = GetAncestor<QueryExpression>(null, null);
                if (query != null)
                {
                    Expression relational = GetExpressionAncestor(null, query);
                    if (relational != null)
                    {
                        limit = TailorUtil.GetRownumExpressionLimit(relational);
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

            node.NormalizeQuotes('`');
        }

        public override void PerformBefore(Interval node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            CoalesceIntervals(null);

            base.PerformBefore(node);
        }

        public override void Perform(LiteralDateTime node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.Perform(node);

            node.Delimiter = '\'';
        }

        public override void Perform(Placeholder node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            base.Perform(node);

            Namer.Perform(this, node);
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

            if (node.LimitFormat != ' ')
            {
                node.LimitFormat = 'L';
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

            if (query.LimitFormat != ' ')
            {
                limit = Math.Min(query.RowLimit, limit);
            }

            query.SetLimit('L', limit);
        }

        void CoalesceIntervals(Expression done)
        {
            Expression node = GetExpressionParent(done);
            if (node == null)
            {
                return;
            }

            Interval leftInterval = TailorUtil.GetInterval(node.Left);
            Interval rightInterval = TailorUtil.GetInterval(node.Right);

            if ((leftInterval != null) && (rightInterval != null))
            {
                    ReplaceIntervalOp(node, leftInterval, rightInterval);
            }
        }

        void ReplaceIntervalOp(Expression node, Interval leftInterval,
            Interval rightInterval)
        {
            if (leftInterval.DateTimeUnit != rightInterval.DateTimeUnit)
            {
                throw new InvalidOperationException(
                    "Can't combine intervals with different units.");
                // well, technically we could (at least for some units), but nobody
                // needed that yet
            }

            decimal v;
            if (node.Operator == ExpressionOperator.Plus)
            {
                v = leftInterval.GetIntegerValue() + rightInterval.GetIntegerValue();
            }
            else if (node.Operator != ExpressionOperator.Minus)
            {
                v = leftInterval.GetIntegerValue() - rightInterval.GetIntegerValue();
            }
            else
            {
                throw new InvalidOperationException("Can't multiply intervals.");
            }

            node.Left = new Interval(true, v, leftInterval.DateTimeUnit);
            node.Operator = null;
            node.Right = null;

            CoalesceIntervals(node);
        }

        #endregion
    }
}
