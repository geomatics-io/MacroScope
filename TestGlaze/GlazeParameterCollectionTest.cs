using System;
using System.Data;
using System.Data.Common;
using NUnit.Framework;
using MacroScope;
using Glaze;

namespace TestGlaze
{
    [TestFixture]
    public class GlazeParameterCollectionTest
    {
        [Test]
        public void TestAdd()
        {
            string[] providers = TestUtil.Providers;
            for (int i = 0; i < providers.Length; ++i)
            {
                if (providers[i].Equals(Factory.MSQLProvider))
                {
                    CheckAdd(Factory.MSQLProvider, "@name", "@name");
                    CheckAdd(Factory.MSQLProvider, ":Name", "@Name");
                }
                else if (providers[i].Equals(Factory.OleDbProvider))
                {
                    CheckAdd(Factory.OleDbProvider, "@name", "@name");
                    CheckAdd(Factory.OleDbProvider, ":NAME", "@NAME");
                }
                else if (providers[i].Equals(Factory.OracleProvider))
                {
                    CheckAdd(Factory.OracleProvider, "@v2", ":v2");
                    CheckAdd(Factory.OracleProvider, ":V2", ":V2");
                }
                else
                {
                    Assert.Fail(string.Format("Unknown provider {0}.", providers[i]));
                }
            }
        }

        void CheckAdd(string databaseProvider, string from, string to)
        {
            if (databaseProvider == null)
            {
                throw new ArgumentNullException("databaseProvider");
            }

            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            GlazeFactory factory = new GlazeFactory(databaseProvider);
            DbCommand command = factory.CreateCommand();

            DbParameter dbParameter = command.CreateParameter();
            dbParameter.ParameterName = from;
            dbParameter.Value = "value";
            command.Parameters.Add(dbParameter);

            Assert.AreEqual(1, command.Parameters.Count);
            Assert.AreEqual(to, command.Parameters[0].ParameterName);
        }

        [Test]
        public void TestGetParameter()
        {
            string[] providers = TestUtil.Providers;
            for (int i = 0; i < providers.Length; ++i)
            {
                CheckGetParameter(providers[i], "@name");
                CheckGetParameter(providers[i], ":name");
            }
        }

        void CheckGetParameter(string databaseProvider, string name)
        {
            if (databaseProvider == null)
            {
                throw new ArgumentNullException("databaseProvider");
            }

            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            GlazeFactory factory = new GlazeFactory(databaseProvider);
            DbCommand command = factory.CreateCommand();

            DbParameter dbParameter = command.CreateParameter();
            dbParameter.ParameterName = name;
            dbParameter.Value = "value";
            command.Parameters.Add(dbParameter);

            DbParameter found = command.Parameters[name];
            Assert.IsNotNull(found);
            Assert.AreEqual("value", found.Value);

            DbParameter first = command.Parameters[0];
            Assert.IsNotNull(first);
            Assert.AreEqual("value", first.Value);
        }
    }
}
