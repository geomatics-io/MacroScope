using System;

namespace MacroScope
{
    /// <summary>
    /// SQL UPDATE statement.
    /// </summary>
    public sealed class UpdateStatement : IStatement
    {
        #region Fields

        private DbObject m_table;

        private Assignment m_assignments;

        private IExpression m_where;

        #endregion

        #region Properties

        public DbObject Table
        {
            get { return m_table; }
            set { m_table = value; }
        }

        public Assignment Assignments
        {
            get { return m_assignments; }
            set { m_assignments = value; }
        }

        public IExpression Where
        {
            get { return m_where; }
            set { m_where = value; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            UpdateStatement updateStatement = new UpdateStatement();

            if (m_table != null)
            {
                updateStatement.Table = (DbObject)(m_table.Clone());
            }

            if (m_assignments != null)
            {
                updateStatement.Assignments = (Assignment)(m_assignments.Clone());
            }

            if (m_where != null)
            {
                updateStatement.Where = (IExpression)(m_where.Clone());
            }

            return updateStatement;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            if (m_table == null)
            {
                throw new InvalidOperationException("UPDATE must have target table.");
            }

            visitor.PerformBefore(this);
            m_table.Traverse(visitor);

            if (m_assignments == null)
            {
                throw new InvalidOperationException("UPDATE must have at least one assignment.");
            }

            visitor.PerformOnAssignments(this);
            m_assignments.Traverse(visitor);

            visitor.PerformOnWhere(this);
            if (m_where != null)
            {
                m_where.Traverse(visitor);
            }

            visitor.PerformAfter(this);
        }

        #endregion
    }
}
