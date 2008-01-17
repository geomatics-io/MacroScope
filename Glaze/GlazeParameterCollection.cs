using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using MacroScope;
using log4net;

namespace Glaze
{
    /// <summary>
    /// <see cref="DbParameterCollection"/> wrapper for multiple database engines.
    /// </summary>
    public class GlazeParameterCollection : DbParameterCollection
    {
        #region Logging

        private static readonly ILog log = LogManager.GetLogger(typeof(GlazeCommand));

        #endregion

        #region Fields

        private readonly IGlazeCommand m_owner;

        private readonly Namer m_namer;

        #endregion

        #region Constructor

        internal GlazeParameterCollection(IGlazeCommand owner)
        {
            if (owner == null)
            {
                throw new ArgumentNullException("owner");
            }

            m_owner = owner;
            m_namer = new Namer('@');
        }

        #endregion

        #region DbParameterCollection interface

        public override int Count
        {
            get
            {
                return Inner.Count;
            }
        }

        public override bool IsFixedSize
        {
            get
            {
                return Inner.IsFixedSize;
            }
        }

        public override bool IsReadOnly
        {
            get
            {
                return Inner.IsReadOnly;
            }
        }

        public override bool IsSynchronized
        {
            get
            {
                return Inner.IsSynchronized;
            }
        }

        public override object SyncRoot
        {
            get
            {
                return Inner.SyncRoot;
            }
        }

        public override bool Contains(object val)
        {
            return Inner.Contains(val);
        }

        public override bool Contains(string val)
        {
            // should we be canonicalizing here?
            return Inner.Contains(val);
        }

        public override int IndexOf(object val)
        {
            return Inner.IndexOf(val);
        }

        public override int IndexOf(string parameterName)
        {
            return Inner.IndexOf(parameterName);
        }

        public override IEnumerator GetEnumerator()
        {
            // well, we _could_ have our own enumerator, probably,
            // but let's keep it simple...
            m_owner.SetDirty();
            return Inner.GetEnumerator();
        }

        public override void CopyTo(Array array, int index)
        {
            Inner.CopyTo(array, index);
        }

        public override int Add(object val)
        {
            m_owner.SetDirty();
            Tailor(val);
            return Inner.Add(val);
        }

        public override void AddRange(Array values)
        {
            m_owner.SetDirty();

            if (values != null)
            {
                for (int i = 0; i < values.Length; ++i)
                {
                    Tailor(values.GetValue(i));
                }
            }

            Inner.AddRange(values);
        }

        public override void Clear()
        {
            m_owner.SetDirty();
            Inner.Clear();
        }

        public override void Insert(int index, object val)
        {
            m_owner.SetDirty();
            Tailor(val);
            Inner.Insert(index, val);
        }

        public override void Remove(object val)
        {
            m_owner.SetDirty();
            Inner.Remove(val);
        }

        public override void RemoveAt(int index)
        {
            m_owner.SetDirty();
            Inner.RemoveAt(index);
        }

        public override void RemoveAt(string parameterName)
        {
            m_owner.SetDirty();
            Inner.RemoveAt(parameterName);
        }

        protected override DbParameter GetParameter(int index)
        {
            DbParameter dbParameter = Inner[index];

            // when the caller has a parameter, they can change its value
            if (dbParameter != null)
            {
                m_owner.SetDirty();
            }

            return dbParameter;
        }

        protected override DbParameter GetParameter(string parameterName)
        {
            if (parameterName == null)
            {
                throw new ArgumentNullException("parameterName");
            }

            DbParameter dbParameter = Inner[TailorName(parameterName)];

            // when the caller has a parameter, they can change its value
            if (dbParameter != null)
            {
                m_owner.SetDirty();
            }

            return dbParameter;
        }

        protected override void SetParameter(int index, DbParameter val)
        {
            m_owner.SetDirty();
            Inner[index] = val;
        }

        protected override void SetParameter(string parameterName, DbParameter val)
        {
            m_owner.SetDirty();
            Inner[TailorName(parameterName)] = val;
        }

        #endregion

        #region Implementation

        DbParameterCollection Inner
        {
            get
            {
                return m_owner.Inner.Parameters;
            }
        }

        void Tailor(object val)
        {
            DbParameter dbParameter = val as DbParameter;
            if (dbParameter != null)
            {            
                string name = dbParameter.ParameterName;
                if ((name == null) || name.Equals(""))
                {
                    // This isn't really a recommended usage, because
                    // while both the tailor and this class
                    // normally use a namer with the same (default) stem,
                    // the correspondence is too easy to break...
                    log.Warn("Naming unnamed variable.");
                    dbParameter.ParameterName = m_namer.GenName();
                }
                else
                {
                    m_owner.BindByName = true;
                    dbParameter.ParameterName = TailorName(name);
                }
            }
        }

        string TailorName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            MacroScopeParser parser = Factory.CreateParser(name);
            Variable variable = parser.variableReference();

            IVisitor tailor = Factory.CreateTailor(m_owner.DatabaseProvider);
            variable.Traverse(tailor);

            Stringifier stringifier = new Stringifier();
            variable.Traverse(stringifier);
            return stringifier.ToSql();
        }

        #endregion
    }
}
