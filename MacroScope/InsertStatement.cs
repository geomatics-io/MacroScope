using System;

namespace MacroScope
{
    /// <summary>
    /// SQL SELECT statement.
    /// </summary>
    public sealed class InsertStatement : IStatement
    {
        #region Fields

        private DbObject m_table;

        private AliasedItem m_columnNames;

        private ExpressionItem m_columnValues;

        #endregion

        #region Properties

        public DbObject Table
        {
            get { return m_table; }
            set { m_table = value; }
        }

        public AliasedItem ColumnNames
        {
            get { return m_columnNames; }
            set { m_columnNames = value; }
        }

        public ExpressionItem ColumnValues
        {
            get { return m_columnValues; }
            set { m_columnValues = value; }
        }

        #endregion

        #region INode Members

        public INode Clone()
        {
            InsertStatement insertStatement = new InsertStatement();

            if (m_table != null)
            {
                insertStatement.Table = (DbObject)(m_table.Clone());
            }

            if (m_columnNames != null)
            {
                insertStatement.ColumnNames = (AliasedItem)(m_columnNames.Clone());
            }

            if (m_columnValues != null)
            {
                insertStatement.ColumnValues = (ExpressionItem)(m_columnValues.Clone());
            }

            return insertStatement;
        }

        public void Traverse(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException("visitor");
            }

            if (m_table == null)
            {
                throw new InvalidOperationException("INSERT must have target table.");
            }

            visitor.PerformBefore(this);
            m_table.Traverse(visitor);

            visitor.PerformOnNames(this);
            if (m_columnNames != null)
            {
                m_columnNames.Traverse(visitor);
            }

            if (m_columnValues == null)
            {
                throw new InvalidOperationException("INSERT must have column values.");
            }

            visitor.PerformOnValues(this);
            m_columnValues.Traverse(visitor);

            visitor.PerformAfter(this);
        }

        #endregion
    }
}
