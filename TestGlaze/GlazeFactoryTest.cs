using System;
using System.Data;
using System.Data.Common;
using NUnit.Framework;
using Glaze;

namespace TestGlaze
{
    [TestFixture]
    public class GlazeFactoryTest
    {
        [Test]
        public void TestCreateCommand()
        {
            string[] providers = TestUtil.Providers;
            for (int i = 0; i < providers.Length; ++i)
            {
                GlazeFactory glazeFactory = new GlazeFactory(providers[i]);
                DbCommand command = glazeFactory.CreateCommand();
                GlazeCommand glazeCommand = command as GlazeCommand;
                Assert.IsNotNull(glazeCommand);
            }
        }

        [Test]
        public void TestCreateConnection()
        {
            string[] providers = TestUtil.Providers;
            for (int i = 0; i < providers.Length; ++i)
            {
                Run(providers[i]);
            }
        }

        [Test]
        public void TestCreateDataAdapter()
        {
            string[] providers = TestUtil.Providers;
            for (int i = 0; i < providers.Length; ++i)
            {
                GlazeFactory glazeFactory = new GlazeFactory(providers[i]);
                DbCommand command = glazeFactory.CreateCommand();
                Assert.IsNotNull(command);

                DbDataAdapter dataAdapter = glazeFactory.CreateDataAdapter();

                // can't be encapsulated because SelectCommand isn't virtual
                dataAdapter.SelectCommand = ((GlazeCommand)command).Inner;

                Assert.IsNotNull(dataAdapter.SelectCommand);
            }
        }

        [Test]
        public void TestCreateDataSourceEnumerator()
        {
            string[] providers = TestUtil.Providers;
            for (int i = 0; i < providers.Length; ++i)
            {
                GlazeFactory glazeFactory = new GlazeFactory(providers[i]);
                if (glazeFactory.CanCreateDataSourceEnumerator)
                {
                    DbDataSourceEnumerator enumerator =
                        glazeFactory.CreateDataSourceEnumerator();
                    Assert.IsNotNull(enumerator);
                }
            }
        }

        static void Run(string databaseProvider)
        {
            if (databaseProvider == null)
            {
                throw new ArgumentNullException("databaseProvider");
            }

            GlazeFactory glazeFactory = new GlazeFactory(databaseProvider);
            DbConnection connection = glazeFactory.CreateConnection();
            Assert.IsNotNull(connection);
        }
    }
}
