using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Reflection;
using MacroScope;
using Antlr.Runtime;
using log4net;

namespace Glaze
{
    /// <summary>
    /// <see cref="DbCommand"/> wrapper for multiple database engines.
    /// </summary>
    public class GlazeCommand : DbCommand, IGlazeCommand
    {
        #region Logging

        private static readonly ILog m_log = LogManager.GetLogger(typeof(GlazeCommand));

        private static readonly ILog m_readLog = LogManager.GetLogger(
            "Glaze.GlazeCommand select");

        #endregion

        #region Fields

        private readonly string m_databaseProvider;

        private DbCommand m_inner;

        private GlazeParameterCollection m_params;

        private IGlazeConnection m_outer;

        private bool m_tailored;

        private IStatement m_statement;

        private bool m_bindByName;

        #endregion

        #region Constructor & destructor

        public GlazeCommand(string databaseProvider, DbCommand inner)
        {
            if (databaseProvider == null)
            {
                throw new ArgumentNullException("databaseProvider");
            }

            if (inner == null)
            {
                throw new ArgumentNullException("inner");
            }

            m_databaseProvider = databaseProvider;
            m_inner = inner;
            m_params = null;
            m_outer = null;
            m_tailored = false;
            m_statement = null;
            m_bindByName = false;
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

        #region IGlazeCommand Members

        public string DatabaseProvider
        {
            get
            {
                return m_databaseProvider;
            }
        }

        public DbCommand Inner
        {
            get
            {
                return m_inner;
            }
        }

        public bool BindByName
        {
            get
            {
                return m_bindByName;
            }

            set
            {
                if (value != m_bindByName)
                {
                    SetOracleBindByName(value);
                    m_bindByName = value;
                }
            }
        }

        public IStatement Statement
        {
            get
            {
                return m_statement;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                m_tailored = false;

                m_inner.CommandText = "";
                m_inner.CommandType = CommandType.Text;
                m_statement = value;
            }
        }

        public void SetDirty()
        {
            m_tailored = false;
        }

        #endregion

        #region DbCommand interface

        public override string CommandText
        {
            get
            {
                if (!HasCommandText() && (m_statement != null))
                {
                    TailorCommand();
                }

                return m_inner.CommandText;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                m_tailored = false;
                m_statement = null;
                m_inner.CommandText = value;
            }
        }

        public override int CommandTimeout
        {
            get
            {
                return m_inner.CommandTimeout;
            }

            set
            {
                m_inner.CommandTimeout = value;
            }
        }

        public override CommandType CommandType
        {
            get
            {
                return m_inner.CommandType;
            }

            set
            {
                m_tailored = false;
                m_inner.CommandType = value;
            }
        }

        public override bool DesignTimeVisible
        {
            get
            {
                return m_inner.DesignTimeVisible;
            }

            set
            {
                m_inner.DesignTimeVisible = value;
            }
        }

        public override UpdateRowSource UpdatedRowSource
        {
            get
            {
                return m_inner.UpdatedRowSource;
            }

            set
            {
                m_inner.UpdatedRowSource = value;
            }
        }

        public override int ExecuteNonQuery()
        {
            Tailor();
            Trace();
            return m_inner.ExecuteNonQuery();
        }

        public override object ExecuteScalar()
        {
            Tailor();
            Trace();
            return m_inner.ExecuteScalar();
        }

        public override void Prepare()
        {
            Tailor();
            m_inner.Prepare();
        }

        public override void Cancel()
        {
            m_inner.Cancel();
        }

        public bool Tailored
        {
            get
            {
                return m_tailored;
            }
        }

        public string TailorCommand()
        {
            bool hasParsePotential = HasCommandText();
            if ((!hasParsePotential && (m_statement == null)) ||
                m_tailored)
            {
                return m_inner.CommandText;
            }

            if (m_inner.CommandType != CommandType.Text)
            {
                m_tailored = true;
                return m_inner.CommandText;
            }

            IStatement statement = hasParsePotential ? CondParse() : m_statement;
            if (statement != null)
            {
                IVisitor tailor = Factory.CreateTailor(m_databaseProvider);
                MAccessTailor accessTailor = tailor as MAccessTailor;
                if (accessTailor != null)
                {
                    List<string> dates = new List<string>();
                    foreach (DbParameter dbParameter in m_inner.Parameters)
                    {
                        if (dbParameter.Value is DateTime)
                        {
                            string name = dbParameter.ParameterName;
                            accessTailor.AddDate(name,
                                (DateTime)(dbParameter.Value));
                            dates.Add(name);
                        }
                    }

                    foreach (string dateName in dates)
                    {
                        m_inner.Parameters.RemoveAt(dateName);
                    }
                }

                statement.Traverse(tailor);

                Stringifier stringifier = new Stringifier();
                statement.Traverse(stringifier);
                m_inner.CommandText = stringifier.ToSql();

                m_statement = statement;
            }

            m_tailored = true;
            return m_inner.CommandText;
        }

        protected override DbConnection DbConnection
        {
            get
            {
                if (m_outer == null)
                {
                    DbConnection inner = m_inner.Connection;
                    if (inner != null)
                    {
                        throw new Exception("GlazeConnection not set.");
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return (DbConnection)m_outer;
                }
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                IGlazeConnection outer = value as GlazeConnection;
                if (outer == null)
                {
                    throw new InvalidOperationException(
                        "GlazeCommand requires GlazeConnection.");
                }

                m_inner.Connection = outer.Inner;
                m_outer = outer;
            }
        }

        protected override DbTransaction DbTransaction
        {
            get
            {
                return m_inner.Transaction;
            }

            set
            {
                m_inner.Transaction = value;
            }
        }

        protected override DbParameterCollection DbParameterCollection
        {
            get
            {
                if (m_params == null)
                {
                    m_params = new GlazeParameterCollection(this);
                }

                return m_params;
            }
        }

        protected override DbParameter CreateDbParameter()
        {
            return m_inner.CreateParameter();
        }

        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
        {
            Tailor();
            Trace();
            return m_inner.ExecuteReader(behavior);
        }

        #endregion

        #region Implementation

        void Trace()
        {
            ILog log = m_log;
            if ((m_statement != null) && (m_statement is SelectStatement))
            {
                log = m_readLog;
            }

            if (!log.IsDebugEnabled)
            {
                return;
            }

            string message = string.Format("SQL: {0}.", m_inner.CommandText);
            log.Debug(message);

            foreach (DbParameter parameter in m_inner.Parameters)
            {
                if (parameter.ParameterName != null)
                {
                    message = string.Format("Parameter: {0} {1}={2}.", parameter.DbType,
                        parameter.ParameterName, parameter.Value);
                }
                else
                {
                    message = string.Format("Parameter: {0} {1}.", parameter.DbType,
                        parameter.Value);
                }

                log.Debug(message);
            }
        }

        /// <summary>
        /// MS SQL Server uses parameter names by default while Oracle doesn't.
        /// Calling this method with <c>true</c> <para>flag</para>.
        /// makes Oracle commands work analogically
        /// to MS SQL Server commands.
        /// </summary>
        /// <param name="flag">
        /// The value to set.
        /// </param>
        void SetOracleBindByName(bool flag)
        {
            if (m_databaseProvider.Equals(Factory.OracleProvider))
            {
                // using reflection to avoid a compile-time dependency
                // on Oracle libraries for .NET.
                Assembly assembly = Assembly.Load("Oracle.DataAccess");
                if (assembly == null)
                {
                    throw new Exception("Can't get Oracle assembly.");
                }

                Type type = assembly.GetType(
                    "Oracle.DataAccess.Client.OracleCommand", true);
                PropertyInfo property = type.GetProperty("BindByName",
                    BindingFlags.Instance | BindingFlags.Public);
                if (property == null)
                {
                    throw new Exception("Can't get BindByName.");
                }

                property.SetValue(m_inner, flag, null);
            }
        }

        bool HasCommandText()
        {
            string text = m_inner.CommandText;
            return (text != null) && !text.Equals("");
        }

        void Tailor()
        {
            TailorCommand();

            if (m_tailored && (m_statement != null))
            {
                if (m_databaseProvider.Equals(Factory.OleDbProvider))
                {
                    OrderParameters();
                }
                else if (m_databaseProvider.Equals(Factory.OracleProvider))
                {
                    RemoveUnusedParameters();
                }
            }
        }

        void OrderParameters()
        {
            DbParameterCollection parameters = m_inner.Parameters;
            if (m_params == null)
            {
                Debug.Assert(parameters.Count == 0);
                return;
            }
            else if (parameters.Count == 0)
            {
                return;
            }
            else
            {
                Debug.Assert(m_params != null);
            }

            Dictionary<string, DbParameter> unique = new Dictionary<string, DbParameter>();
            while (parameters.Count > 0)
            {
                DbParameter last = parameters[parameters.Count - 1];
                if (last == null)
                {
                    throw new InvalidOperationException(
                        "DbParameterCollection has null parameter.");
                }

                string name = last.ParameterName;
                if (name == null)
                {
                    throw new Exception("Unnamed parameters can't be reordered.");
                }

                string key = Variable.Canonicalize(name);
                Debug.Assert(key != null);

                if (unique.ContainsKey(key))
                {
                    string message = string.Format("Duplicate variable name \"{0}\".",
                        key);
                    throw new InvalidOperationException(message);
                }

                unique.Add(key, last);
                parameters.Remove(last);
            }

            ParamGrower grower = new ParamGrower();
            m_statement.Traverse(grower);

            string[] embedded = grower.GetAllParams();
            if (embedded == null)
            {
                throw new InvalidOperationException(
                    "Parameters are specified but the command text doesn't use any.");
            }

            Dictionary<string, object> used = new Dictionary<string, object>();
            for (int i = 0; i < embedded.Length; ++i)
            {
                string key = Variable.Canonicalize(embedded[i]);
                DbParameter ordered = null;
                bool first = unique.ContainsKey(key);
                if (first)
                {
                    ordered = unique[key];
                    Debug.Assert(ordered != null);
                }
                else
                {
                    string origKey = grower.GetOriginalKey(embedded[i]);
                    if (origKey == null)
                    {
                        string message = string.Format("Unknown parameter name {0}.",
                            embedded[i]);
                        m_log.Warn(message);
                    }
                    else
                    {
                        ordered = m_inner.CreateParameter();
                        ordered.ParameterName = embedded[i];
                        ordered.Value = used[origKey];
                    }
                }

                unique.Remove(key);

                if (ordered != null)
                {
                    parameters.Add(ordered);

                    if (first)
                    {
                        object v = ordered.Value;
                        if (v == null)
                        {
                            string message = string.Format("Parameter \"{0}\" has null value.",
                                ordered.ParameterName);
                            throw new Exception(message);
                        }

                        used.Add(key, v);
                    }
                }
            }
        }

        void RemoveUnusedParameters()
        {
            DbParameterCollection parameters = m_inner.Parameters;
            if (m_params == null)
            {
                Debug.Assert(parameters.Count == 0);
                return;
            }
            else if (parameters.Count == 0)
            {
                return;
            }
            else
            {
                Debug.Assert(m_params != null);
            }

            ParamPicker picker = new ParamPicker();
            m_statement.Traverse(picker);

            for (int i = parameters.Count - 1; i >= 0; --i)
            {
                DbParameter last = parameters[i];
                string name = last.ParameterName;
                if ((name != null) && !name.Equals(""))
                {
                    if (!picker.IsParam(name))
                    {
                        parameters.Remove(last);
                    }
                }
            }
        }

        IStatement CondParse()
        {
            try
            {
                return Factory.CreateStatement(m_inner.CommandText);
            }
            catch (RecognitionException)
            {
                string message;
                if (m_inner.CommandText != null)
                {
                    message = string.Format("Can't parse \"{0}\".", m_inner.CommandText);
                }
                else
                {
                    message = "Can't parse null.";
                }

                m_log.Warn(message);
                return null;
            }
        }

        #endregion
    }
}
