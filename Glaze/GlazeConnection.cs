using System;
using System.Data;
using System.Data.Common;
using System.Transactions;
using IsolationLevel = System.Data.IsolationLevel;

namespace Glaze
{
    /// <summary>
    /// <see cref="DbConnection"/> wrapper for multiple database engines.
    /// </summary>
    public class GlazeConnection : DbConnection, IGlazeConnection
    {
        #region Fields

        private readonly IGlazeFactory m_owner;

        private DbConnection m_inner;

        #endregion

        #region Constructor & destructor

        internal GlazeConnection(IGlazeFactory owner, DbConnection inner)
        {
            if (owner == null)
            {
                throw new ArgumentNullException("owner");
            }

            if (inner == null)
            {
                throw new ArgumentNullException("inner");
            }

            m_owner = owner;
            m_inner = inner;
        }

        protected override void Dispose(bool disposing)
        {
            // not thread safe, but neither is the MS sample
            // at http://msdn2.microsoft.com/en-us/library/fs2xkftw.aspx
            if (disposing && (m_inner != null)) 
            {
                m_inner.Dispose();
                m_inner = null;
            }

            base.Dispose(disposing);
        }

        #endregion

        #region IGlazeConnection Members

        public DbConnection Inner
        {
            get
            {
                return m_inner;
            }
        }

        #endregion

        #region DbConnection interface

        public override string ConnectionString
        {
            get
            {
                return m_inner.ConnectionString;
            }

            set
            {
                m_inner.ConnectionString = value;
            }
        }

        public override int ConnectionTimeout
        {
            get
            {
                return m_inner.ConnectionTimeout;
            }
        }

        public override string Database
        {
            get
            {
                return m_inner.Database;
            }
        }

        public override string DataSource
        {
            get
            {
                return m_inner.DataSource;
            }
        }

        public override string ServerVersion
        {
            get
            {
                return m_inner.ServerVersion;
            }
        }

        public override ConnectionState State
        {
            get
            {
                return m_inner.State;
            }
        }

        public override void Open()
        {
            m_inner.Open();
        }

        public override void Close()
        {
            m_inner.Close();
        }

        public override DataTable GetSchema()
        {
            return m_inner.GetSchema();
        }

        public override DataTable GetSchema(string collectionName)
        {
            return m_inner.GetSchema(collectionName);
        }

        public override DataTable GetSchema(string collectionName,
            string[] restrictionValues)
        {
            return m_inner.GetSchema(collectionName, restrictionValues);
        }

        public override void ChangeDatabase(string databaseName)
        {
            m_inner.ChangeDatabase(databaseName);
        }

        public override void EnlistTransaction(Transaction transaction)
        {
            m_inner.EnlistTransaction(transaction);
        }

        protected override DbCommand CreateDbCommand()
        {
            DbCommand core = m_inner.CreateCommand();
            GlazeCommand glazeCommand = new GlazeCommand(m_owner.DatabaseProvider, core);
            glazeCommand.Connection = this;
            return glazeCommand;
        }

        protected override DbTransaction BeginDbTransaction(
            IsolationLevel isolationLevel)
        {
            return m_inner.BeginTransaction(isolationLevel);
        }

        
        #endregion
    }
}
