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

        const int MIN_VALUE = 2;

        const int MULTIPLIER = 3;

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

        [Test]
        public void TestComandText()
        {
            RunAll(CheckCommandText);
        }

        [Test]
        public void TestDbTransaction()
        {
            RunAll(CheckDbTransaction);
        }

        [Test]
        public void TestExecuteReader()
        {
            RunAll(CheckExecuteReader);
        }

        void CheckExecuteReader(GlazeFactory glazeFactory, DbConnection connection)
        {
            CheckQuoting(connection);
            CheckCase(connection);

            string[] conditions = { "null is null", "not 2 < 1",
                "'abcd' like '%c%'",  "'abcd' not like '%e%'", "'a' like '_'",
                "not ('a' like '__')", "'_' like '_'", 
            };
            // FIXME: standard (and Oracle) '[' pattern doesn't work
            // for MS engines, which use brackets for ranges. It could be
            // replaced by '[[]', but it isn't clear when (as the change
            // isn't idempotent).
            for (int i = 0; i < conditions.Length; ++i)
            {
                CheckCondition(connection, conditions[i]);
            }

            CheckTop(connection);

            CreateCountedRows(connection);

            int etalon = CheckParameters(connection, true);
            int alternative = CheckParameters(connection, false);
            Assert.AreEqual(etalon, alternative);

            alternative = CheckUnnamedParameters(connection);
            Assert.AreEqual(etalon, alternative);

            alternative = CheckTableAlias(connection);
            Assert.AreEqual(etalon, alternative);

            alternative = CheckTableAliasWithRepeat(connection, false);
            Assert.AreEqual(etalon, alternative);

            alternative = CheckTableAliasWithRepeat(connection, true);
            Assert.AreEqual(etalon, alternative);

            CheckJoin(connection);
            CheckAlias(connection);
            CheckNoSpace(connection);
        }

        int CheckTableAlias(DbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT a.key1 FROM table1 AS a
WHERE @Min <= a.key1 and a.key1 < @Max";

            AddParameter(command, "@Min", MIN_VALUE);
            AddParameter(command, "@Max", MULTIPLIER * MIN_VALUE);

            DbDataReader reader = command.ExecuteReader();
            Assert.IsNotNull(reader);
            try
            {
                Assert.AreEqual(1, reader.FieldCount);

                int found = 0;
                while (reader.Read())
                {
                    ++found;

                    object obj = reader.GetValue(0);
                    int v = Convert.ToInt32(obj);
                    Assert.IsTrue(MIN_VALUE <= v);
                    Assert.IsTrue(v < MULTIPLIER * MIN_VALUE);
                }

                return found;
            }
            finally
            {
                reader.Close();
            }
        }

        int CheckTableAliasWithRepeat(DbConnection connection, bool includeExtra)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT a.key1 FROM table1 AS a
WHERE @Min <= a.key1 and a.key1 < @Multiplier * @Min";

            AddParameter(command, "@Min", MIN_VALUE);
            AddParameter(command, "@Multiplier", MULTIPLIER);

            if (includeExtra)
            {
                // there are applications which actually have extra
                // params in reused commands...
                AddParameter(command, "@Max", MULTIPLIER * MIN_VALUE);
            }

            DbDataReader reader = command.ExecuteReader();
            Assert.IsNotNull(reader);
            try
            {
                Assert.AreEqual(1, reader.FieldCount);

                int found = 0;
                while (reader.Read())
                {
                    ++found;

                    object obj = reader.GetValue(0);
                    int v = Convert.ToInt32(obj);
                    Assert.IsTrue(MIN_VALUE <= v);
                    Assert.IsTrue(v < MULTIPLIER * MIN_VALUE);
                }

                return found;
            }
            finally
            {
                reader.Close();
            }
        }

        void CheckJoin(DbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT count(*) FROM table1
inner join table2 on table1.key1 = table2.key2 AND
    key1 > 10";
            int rv = DoExecuteReader(command);
            Assert.IsTrue(rv == 1);
        }

        int CheckUnnamedParameters(DbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT key1 FROM table1
WHERE ? <= key1 and key1 < ?";

            AddParameter(command, null, MIN_VALUE);
            AddParameter(command, null, MULTIPLIER * MIN_VALUE);

            DbDataReader reader = command.ExecuteReader();
            Assert.IsNotNull(reader);
            try
            {
                Assert.AreEqual(1, reader.FieldCount);

                int found = 0;
                while (reader.Read())
                {
                    ++found;

                    object obj = reader.GetValue(0);
                    int v = Convert.ToInt32(obj);
                    Assert.IsTrue(MIN_VALUE <= v);
                    Assert.IsTrue(v < MULTIPLIER * MIN_VALUE);
                }

                return found;
            }
            finally
            {
                reader.Close();
            }
        }

        int CheckParameters(DbConnection connection, bool inOrder)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT key1 FROM table1
WHERE @min<=key1 and key1<@max";

            if (inOrder)
            {
                AddParameter(command, "@min", MIN_VALUE);
                AddParameter(command, "@max", MULTIPLIER * MIN_VALUE);
            }
            else
            {
                AddParameter(command, "@max", MULTIPLIER * MIN_VALUE);
                AddParameter(command, "@min", MIN_VALUE);
            }

            DbDataReader reader = command.ExecuteReader();
            Assert.IsNotNull(reader);
            try
            {
                Assert.AreEqual(1, reader.FieldCount);

                int found = 0;
                while (reader.Read())
                {
                    ++found;

                    object obj = reader.GetValue(0);
                    int v = Convert.ToInt32(obj);
                    Assert.IsTrue(MIN_VALUE <= v);
                    Assert.IsTrue(v < MULTIPLIER * MIN_VALUE);
                }

                return found;
            }
            finally
            {
                reader.Close();
            }
        }

        void AddParameter(DbCommand command, string paramName, int paramValue)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }

            DbParameter dbParameter = command.CreateParameter();

            if (paramName != null)
            {
                dbParameter.ParameterName = paramName;
            }

            dbParameter.Value = paramValue;

            DbParameterCollection parameters = command.Parameters;
            Assert.IsNotNull(parameters);
            Assert.IsInstanceOfType(typeof(GlazeParameterCollection), parameters);

            parameters.Add(dbParameter);
        }

        void CheckCase(DbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT CASE key1
WHEN 1 THEN 'one'
WHEN 2 THEN 'two'
ELSE 'other' END
FROM table1";
            DbDataReader reader = command.ExecuteReader();
            Assert.IsNotNull(reader);

            try
            {
                Assert.AreEqual(1, reader.FieldCount);
            }
            finally
            {
                reader.Close();
            }
        }

        void CheckCondition(DbConnection connection, string condition)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            if (condition == null)
            {
                throw new ArgumentNullException("condition");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = string.Format(@"SELECT CASE
WHEN {0} THEN 'yes'
ELSE 'no' END", condition);
            DbDataReader reader = command.ExecuteReader();
            Assert.IsNotNull(reader);

            try
            {
                Assert.AreEqual(1, reader.FieldCount);
                Assert.IsTrue(reader.Read());
                object conditionResult = reader.GetValue(0);
                Assert.AreEqual("yes", conditionResult.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        void CheckAlias(DbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT count(*) as c, string1
FROM table1 group by string1 order by c desc";
            DbDataReader reader = command.ExecuteReader();
            Assert.IsNotNull(reader);

            try
            {
                Assert.AreEqual(2, reader.FieldCount);
            }
            finally
            {
                reader.Close();
            }
        }

        void CheckNoSpace(DbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = "select*from\"table1\"";
            DbDataReader reader = command.ExecuteReader();
            Assert.IsNotNull(reader);

            try
            {
                Assert.IsTrue(reader.FieldCount > 0);
            }
            finally
            {
                reader.Close();
            }
        }

        void CheckTop(DbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = "select top 10 * from table1";
            DbDataReader reader = command.ExecuteReader();
            Assert.IsNotNull(reader);

            try
            {
                Assert.IsTrue(reader.FieldCount > 2);
            }
            finally
            {
                reader.Close();
            }
        }

        void CheckQuoting(DbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT count(*) AS \"long title\" FROM [table1]";
            DbDataReader reader = command.ExecuteReader();
            Assert.IsNotNull(reader);
            reader.Close();
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

        void CheckCommandText(GlazeFactory glazeFactory, DbConnection connection)
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
            Assert.AreEqual("", command.CommandText);
        }

        void CheckDbTransaction(GlazeFactory glazeFactory, DbConnection connection)
        {
            if (glazeFactory == null)
            {
                throw new ArgumentNullException("glazeFactory");
            }

            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            CheckTransactionCommit(connection);
            CheckTransactionRollback(connection);
        }

        void CheckTransactionCommit(DbConnection connection)
        {
            CleanTestRows(connection);

            DbCommand command;
            DbTransaction transaction = connection.BeginTransaction();
            try
            {
                command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO table1(string1, date1)
VALUES('GlazeTest', 2006-12-31T23:59:58)";
                command.Transaction = transaction;
                command.ExecuteNonQuery();

                DbTransaction t = transaction;
                transaction = null;
                t.Commit();
            }
            finally
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
            }

            command = connection.CreateCommand();
            command.CommandText = "select * from table1 where string1='GlazeTest'";
            Assert.AreEqual(1, DoExecuteReader(command));
        }

        void CheckTransactionRollback(DbConnection connection)
        {
            CleanTestRows(connection);

            DbCommand command;
            DbTransaction transaction = connection.BeginTransaction();
            try
            {
                command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO table1(string1, date1)
VALUES('GlazeTest', 2006-12-31T23:59:58)";
                command.Transaction = transaction;
                command.ExecuteNonQuery();
            }
            finally
            {
                transaction.Rollback();
            }

            command = connection.CreateCommand();
            command.CommandText = "select * from table1 where string1='GlazeTest'";
            Assert.AreEqual(0, DoExecuteReader(command));
        }

        void CleanTestRows(DbConnection connection)
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText = "delete from table1 where string1='GlazeTest'";
            command.ExecuteNonQuery();
        }

        int GetTotalRowCount(DbConnection connection)
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText = "select count(*) from table1";
            return Convert.ToInt32(command.ExecuteScalar());
        }

        void CreateCountedRows(DbConnection connection)
        {
            if (GetTotalRowCount(connection) > MIN_VALUE)
            {
                return;
            }

            for (int i = 0; i < 2 * MIN_VALUE; ++i)
            {
                DbCommand command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO table1(string1, date1)
VALUES('Counted', 2008-01-29T09:35:24)";
                command.ExecuteNonQuery();
            }
        }

        int DoExecuteReader(DbCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }

            DbDataReader reader = command.ExecuteReader();
            Assert.IsNotNull(reader);
            try
            {
                int found = 0;
                while (reader.Read())
                {
                    ++found;
                }

                return found;
            }
            finally
            {
                reader.Close();
            }
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
