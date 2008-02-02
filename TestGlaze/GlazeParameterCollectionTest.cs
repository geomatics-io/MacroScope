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
            CheckAdd(Factory.MSQLProvider, "@name", "@name");
            CheckAdd(Factory.MSQLProvider, ":Name", "@Name");
            CheckAdd(Factory.OleDbProvider, "@name", "@name");
            CheckAdd(Factory.OleDbProvider, ":NAME", "@NAME");
            CheckAdd(Factory.OracleProvider, "@v2", ":v2");
            CheckAdd(Factory.OracleProvider, ":V2", ":V2");
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
            CheckGetParameter(Factory.MSQLProvider, "@name");
            CheckGetParameter(Factory.MSQLProvider, ":name");
            CheckGetParameter(Factory.OracleProvider, "@name");
            CheckGetParameter(Factory.OracleProvider, ":name");
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
