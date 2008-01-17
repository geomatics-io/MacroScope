using System;
using System.Data;
using System.Data.Common;
using System.Security;
using System.Security.Permissions;
using MacroScope;

namespace Glaze
{
    /// <summary>
    /// Wrapper for <see cref="DbProviderFactory"/> producing
    /// objects of this library.
    /// </summary>
    public class GlazeFactory : DbProviderFactory, IGlazeFactory
    {
        #region Fields

        private readonly string m_databaseProvider;

        private readonly DbProviderFactory m_inner;

        #endregion

        #region Constructor

        public GlazeFactory(string databaseProvider)
        {
            if (databaseProvider == null)
            {
                throw new ArgumentNullException("databaseProvider");
            }

            m_databaseProvider = databaseProvider;

            m_inner = DbProviderFactories.GetFactory(databaseProvider);
            if (m_inner == null)
            {
                string message = string.Format("No DbProviderFactory for {0}.",
                    databaseProvider);
                throw new Exception(message);
            }
        }

        #endregion

        #region IGlazeFactory Members

        public string DatabaseProvider
        {
            get
            {
                return m_databaseProvider;
            }
        }

        #endregion

        #region DbProviderFactory interface

        public override bool CanCreateDataSourceEnumerator
        {
            get
            {
                return m_inner.CanCreateDataSourceEnumerator;
            }
        }

        public override DbConnection CreateConnection()
        {
            DbConnection core = m_inner.CreateConnection();
            return new GlazeConnection(this, core);
        }

        public override DbCommand CreateCommand()
        {
            DbCommand core = m_inner.CreateCommand();
            return new GlazeCommand(m_databaseProvider, core);
        }

        public override DbParameter CreateParameter()
        {
            return m_inner.CreateParameter();
        }

        public override DbCommandBuilder CreateCommandBuilder()
        {
            throw new NotImplementedException(
                "This library cannot have a command builder because DbCommandBuilder isn't virtual enough.");
        }

        public override DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return m_inner.CreateConnectionStringBuilder();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return m_inner.CreateDataAdapter();
        }

        public override DbDataSourceEnumerator CreateDataSourceEnumerator()
        {
            return m_inner.CreateDataSourceEnumerator();
        }

        public override CodeAccessPermission CreatePermission(PermissionState state)
        {
            return m_inner.CreatePermission(state);
        }

        #endregion
    }
}
