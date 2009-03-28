using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MacroScope
{
    /// <summary>
    /// Represents a query expression
    /// (i.e. <c>SELECT count(*) FROM t WHERE id IS NOT NULL</c>)
    /// of a SQL SELECT statement.
    /// </summary>
    /// <remarks>
    /// A query expression is a <see cref="SelectStatement">SELECT statement</see>
    /// but not necessarily vice versa - one select statement can consist
    /// of multiple query expressions.
    /// </remarks>
    public sealed class QueryExpression : INode
    {
        #region Fields

        private bool m_distinct = false;

        private bool m_all = false;

        private char m_limitFormat = ' ';

        private int m_limit = 0;

        private AliasedItem m_selectItems;

        private AliasedItem m_from;

        private IExpression m_where;

        private GroupByClause m_groupBy;

        private OrderExpression m_orderBy;

        private QueryExpression m_next;

        #endregion

        #region Accessors

        /// <summary>
        /// Valid values are ' ' when the query doesn't limit the number of returned rows,
        /// 't' or 'T' for MS TOP clause, 'r' or 'R' for Oracle ROWNUM condition,
        /// 'l' or 'L' for MySQL LIMIT clause.
        /// </summary>
        public char LimitFormat
        {
            get
            {
                return m_limitFormat;
            }

            set
            {
                char v = char.ToUpperInvariant(value);
                if ((v != ' ') && (v != 'T') && (v != 'R') && (v != 'L'))
                {
                    string message = string.Format("Invalid query expression limit format {0}.",
                        value);
                    throw new ArgumentException(message, "value");
                }

                m_limitFormat = v;
            }
        }

        /// <summary>
        /// The limit on returned rows, or 0 if it isn't set.
        /// </summary>
        /// <remarks>
        /// Use <see cref="LimitFormat"/> to establish whether the limit is set.
        /// </remarks>
        public int RowLimit
        {
            get
            {
                return (m_limitFormat == ' ') ? 0 : m_limit;
            }
        }

        /// <summary>
        /// When the limit format is set to 'T', returns the limit or returned rows, otherwise null.
        /// </summary>
        public int? Top
        {
            get
            {
                if (m_limitFormat == 'T')
                {
                    return m_limit;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// When the limit format is set to 'L', returns the limit or returned rows, otherwise null.
        /// </summary>
        public int? Limit
        {
            get
            {
                if (m_limitFormat == 'L')
                {
                    return m_limit;
                }
                else
                {
                    return null;
                }
            }
        }

        public bool Distinct
        {
            get
            {
                return m_distinct;
            }

            set
            {
                m_distinct = value;
            }
        }

        public bool HasNext
        {
            get
            {
                return m_next != null;
            }
        }

        /// <summary>
        /// Set if the union with the previous query expression is
        /// UNION ALL.
        /// </summary>
        public bool All
        {
            get
            {
                return m_all;
            }

            set
            {
                m_all = value;
            }
        }

        public AliasedItem SelectItems
        {
            get
            {
                return m_selectItems;
            }

            set
            {
                m_selectItems = value;
            }
        }

        public AliasedItem From
        {
            get { return m_from; }
            set { m_from = value; }
        }

        public IExpression Where
        {
            get { return m_where; }
            set { m_where = value; }
        }

        public GroupByClause GroupBy
        {
            get { return m_groupBy; }
            set { m_groupBy = value; }
        }

        public OrderExpression OrderBy
        {
            get { return m_orderBy; }
            set { m_orderBy = value; }
        }

        #endregion

        #region Build methods

        public void Add(QueryExpression tail)
        {
            if (tail == null)
            {
                throw new ArgumentNullException("tail");
            }

            if (m_next == null)
            {
                m_next = tail;
            }
            else
            {
                m_next.Add(tail);
            }
        }

        public void SetLimit(char limitFormat, int limit)
        {
            LimitFormat = limitFormat;
            m_limit = limit;
        }

        internal void SetOrderBy(OrderExpression orderBy)
        {
            if (m_next == null)
            {
                m_orderBy = orderBy;
            }
            else
            {
                m_next.SetOrderBy(orderBy);
            }
        }

        internal OrderExpression GetOrderBy()
        {
            if (m_next == null)
            {
                return m_orderBy;
            }
            else
            {
                return m_next.GetOrderBy();
            }
        }

        internal IList<QueryExpression> GetUnion()
        {
            IList<QueryExpression> union;
            if (m_next == null)
            {
                union = new List<QueryExpression>();
            }
            else
            {
                union = m_next.GetUnion();
            }

            union.Insert(0, this);
            return union;
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            QueryExpression queryExpression = new QueryExpression();

            queryExpression.Distinct = m_distinct;
            queryExpression.All = m_all;
            queryExpression.SetLimit(m_limitFormat, m_limit);

            if (m_selectItems != null)
            {
                queryExpression.SelectItems = (AliasedItem)(m_selectItems.Clone());
            }

            if (m_from != null)
            {
                queryExpression.From = (AliasedItem)(m_from.Clone());
            }

            if (m_where != null)
            {
                queryExpression.Where = (IExpression)(m_where.Clone());
            }

            if (m_groupBy != null)
            {
                queryExpression.GroupBy = (GroupByClause)(m_groupBy.Clone());
            }

            if (m_orderBy != null)
            {
                queryExpression.OrderBy = (OrderExpression)(m_orderBy.Clone());
            }

            if (m_next != null)
            {
                queryExpression.Add((QueryExpression)(m_next.Clone()));
            }

            return queryExpression;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            visitor.PerformBefore(this);
            if (m_selectItems == null)
            {
                throw new InvalidOperationException(
                    "Fully-constructed query expression must have select items.");
            }

            m_selectItems.Traverse(visitor);

            visitor.PerformOnFrom(this);
            if (m_from != null)
            {
                m_from.Traverse(visitor);
            }

            visitor.PerformOnWhere(this);
            if (m_where != null)
            {
                m_where.Traverse(visitor);
            }

            visitor.PerformOnGroupBy(this);
            if (m_groupBy != null)
            {
                m_groupBy.Traverse(visitor);
            }

            visitor.PerformOnOrderBy(this);
            if (m_orderBy != null)
            {
                m_orderBy.Traverse(visitor);
            }

            visitor.PerformAfter(this);

            if (m_next != null)
            {
                m_next.Traverse(visitor);
            }
        }

        #endregion
    }
}
