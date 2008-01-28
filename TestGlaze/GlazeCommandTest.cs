using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using NUnit.Framework;
using MacroScope;
using Glaze;

namespace TestGlaze
{
    [TestFixture]
    public class GlazeCommandTest
    {
        delegate void ConnectedTest(GlazeFactory glazeFactory, DbConnection connection);

        [Test]
        public void TestDatabaseProvider()
        {
            string[] providers = TestUtil.Providers;
            for (int i = 0; i < providers.Length; ++i)
            {
                GlazeFactory glazeFactory = new GlazeFactory(providers[i]);
                GlazeCommand glazeCommand = (GlazeCommand)(glazeFactory.CreateCommand());
                Assert.AreEqual(providers[i], glazeCommand.DatabaseProvider);
            }
        }

        [Test]
        public void TestBindByName()
        {
            RunAll(CheckBindByName);
        }

        void CheckBindByName(GlazeFactory glazeFactory, DbConnection connection)
        {
            if (glazeFactory == null)
            {
                throw new ArgumentNullException("glazeFactory");
            }

            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = glazeFactory.CreateCommand();
            Assert.IsNotNull(command);
            GlazeCommand glazeCommand = (GlazeCommand)command;
            Assert.IsFalse(glazeCommand.BindByName);

            glazeCommand.BindByName = true;
            Assert.IsTrue(glazeCommand.BindByName);
        }

        static void RunAll(ConnectedTest test)
        {
            string[] providers = TestUtil.Providers;
            for (int i = 0; i < providers.Length; ++i)
            {
                Run(providers[i], test);
            }
        }

        static void Run(string databaseProvider, ConnectedTest test)
        {
            if (databaseProvider == null)
            {
                throw new ArgumentNullException("databaseProvider");
            }

            AppSettingsReader config = new AppSettingsReader();
            string connectionString = config.GetValue(databaseProvider,
                typeof(string)) as string;
            GlazeFactory glazeFactory = new GlazeFactory(databaseProvider);
            DbConnection connection = glazeFactory.CreateConnection();

            connection.ConnectionString = connectionString;
            connection.Open();
            try
            {
                test(glazeFactory, connection);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
