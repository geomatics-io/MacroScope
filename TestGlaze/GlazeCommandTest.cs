using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Text;
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

        [Test]
        public void TestExecuteScalar()
        {
            RunAll(CheckExecuteScalar);
        }

        [Test]
        public void TestExecuteNonQuery()
        {
            RunAll(CheckExecuteNonQuery);
        }

        [Test]
        public void TestStatement()
        {
            RunAll(CheckStatement);
        }

        void CheckExecuteReader(GlazeFactory glazeFactory, DbConnection connection)
        {
            CheckQuoting(connection);
            CheckCase(connection);

            string[] conditions = { "null is null", "'a' is not null", 
                "not null is not null", "not 2 < 1",
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

        void CheckCrossJoin(DbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            CleanTestRows(connection, null);

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"insert into table1(number1, number1a)
values(1, 2)";
            command.ExecuteNonQuery();

            command.CommandText = @"insert into table1(number1, number1a)
values(3, 4)";
            command.ExecuteNonQuery();

            command.CommandText = @"select count(*) from table1 a
cross join table1 b";
            object n = command.ExecuteScalar();
            Assert.AreEqual(4, n);

            command.CommandText = @"select count(*) from table1 a,
table1 b cross join table1 c";
            n = command.ExecuteScalar();
            Assert.AreEqual(8, n);

            command.CommandText = @"select count(*) from table1 a,
table1 b cross join table1 c, table1 d";
            n = command.ExecuteScalar();
            Assert.AreEqual(16, n);
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

            CheckCase(connection, @"SELECT CASE key1
WHEN 1 THEN 'one'
WHEN 2 THEN 'two'
ELSE 'other' END
FROM table1");

            CheckCase(connection, @"SELECT CASE
WHEN string3 is not null THEN string1 || ' ' || string3
ELSE string1
END CASE
FROM table1
LEFT JOIN table3 ON table1.key1 = table3.key3");
        }

        void CheckCase(DbConnection connection, string commandText)
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
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
            CleanTestRows(connection, "string1='GlazeTest'");
        }

        void CleanTestRows(DbConnection connection, string cond)
        {
            StringBuilder cmd = new StringBuilder();
            cmd.Append("delete from table1");
            if (cond != null)
            {
                cmd.AppendFormat(" where {0}", cond);
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = cmd.ToString();
            command.ExecuteNonQuery();
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

        int GetTotalRowCount(DbConnection connection)
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText = "select count(*) from table1";
            return Convert.ToInt32(command.ExecuteScalar());
        }

        void CheckExecuteNonQuery(GlazeFactory glazeFactory, DbConnection connection)
        {
            if (glazeFactory == null)
            {
                throw new ArgumentNullException("glazeFactory");
            }

            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            CheckDelete(connection);
            CheckInsertDate(connection);
            CheckInsertDefault(connection);
	}

        void CheckDelete(DbConnection connection)
        {
            GlazeCommand command = (GlazeCommand)(connection.CreateCommand());
            command.CommandText = "delete from table1 where 0=1";
            int c = command.ExecuteNonQuery();
            Assert.AreEqual(0, c);

            c = command.ExecuteNonQuery();
            Assert.AreEqual(0, c);
        }

        void CheckInsertDate(DbConnection connection)
        {
            DbCommand dbCommand = connection.CreateCommand();
            dbCommand.CommandText = "delete table1 where string1=@name";

            DbParameter dbParameter = dbCommand.CreateParameter();
            dbParameter.ParameterName = "@name";
            dbParameter.Value = "GlazeTest";
            dbCommand.Parameters.Add(dbParameter);

            int c = dbCommand.ExecuteNonQuery();
            Assert.IsTrue(c >= 0);

            dbCommand = connection.CreateCommand();
            dbCommand.CommandText = @"INSERT INTO table1(string1, date1)
VALUES(@name, 2006-12-31T23:59:58)";

            dbParameter = dbCommand.CreateParameter();
            dbParameter.ParameterName = "@name";
            dbParameter.Value = "GlazeTest";
            dbCommand.Parameters.Add(dbParameter);

            c = dbCommand.ExecuteNonQuery();
            Assert.AreEqual(1, c);

            DateTime dt = GetWrittenDateTime(connection);
            Assert.AreEqual(2006, dt.Year);
            Assert.AreEqual(12, dt.Month);
            Assert.AreEqual(31, dt.Day);
            Assert.AreEqual(23, dt.Hour);
            Assert.AreEqual(59, dt.Minute);
            Assert.AreEqual(58, dt.Second);

            dbCommand = connection.CreateCommand();
            dbCommand.CommandText = @"UPDATE table1 SET date1=@date1
WHERE string1=@string1";

            dbParameter = dbCommand.CreateParameter();
            dbParameter.ParameterName = "@string1";
            dbParameter.Value = "GlazeTest";
            dbCommand.Parameters.Add(dbParameter);

            DateTime altDate = DateTime.Now;
            dbParameter = dbCommand.CreateParameter();
            dbParameter.ParameterName = "@date1";
            dbParameter.Value = altDate;
            dbCommand.Parameters.Add(dbParameter);

            c = dbCommand.ExecuteNonQuery();
            Assert.AreEqual(1, c);

            dt = GetWrittenDateTime(connection);
            Assert.AreEqual(altDate.Year, dt.Year);
            Assert.AreEqual(altDate.Month, dt.Month);
            Assert.AreEqual(altDate.Day, dt.Day);
            Assert.AreEqual(altDate.Hour, dt.Hour);
            Assert.AreEqual(altDate.Minute, dt.Minute);
            Assert.AreEqual(altDate.Second, dt.Second);

            dbCommand = connection.CreateCommand();
            dbCommand.CommandText = @"DELETE FROM table1 WHERE string1='GlazeTest'";

            c = dbCommand.ExecuteNonQuery();
            Assert.AreEqual(1, c);
        }

        void CheckInsertDefault(DbConnection connection)
        {
            CleanTestRows(connection, null);

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"insert into table1(number1, number1a)
values(default, 9)";
            int c = command.ExecuteNonQuery();
            Assert.AreEqual(1, c);

            command.CommandText = @"select count(*) from table1
where number1=4";
            object n = command.ExecuteScalar();
            Assert.AreEqual(1, n);

            command.CommandText = @"insert into table1(number1, number1a)
values(10, default)";
            c = command.ExecuteNonQuery();
            Assert.AreEqual(1, c);

            command.CommandText = @"select count(*) from table1
where number1a=2";
            n = command.ExecuteScalar();
            Assert.AreEqual(1, n);
        }

        static DateTime GetWrittenDateTime(DbConnection connection)
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT date1 from table1 WHERE string1='GlazeTest'";
            object d = command.ExecuteScalar();
            return (DateTime)d;
        }

        void CheckStatement(GlazeFactory glazeFactory, DbConnection connection)
        {
            QueryExpression queryExpression = new QueryExpression();
            queryExpression.SelectItems = new AliasedItem(
                new Expression(new IntegerValue(1),
                    ExpressionOperator.Minus,
                    new IntegerValue(2)));

            GlazeCommand command = (GlazeCommand)(connection.CreateCommand());
            command.Statement = new SelectStatement(queryExpression);

            object c = command.ExecuteScalar();
            Assert.IsNotNull(c);
            int d = Convert.ToInt32(c);
            Assert.AreEqual(-1, d);

            InsertStatement insertStatement = new InsertStatement();
            insertStatement.Table = new DbObject(new Identifier("no_table"));
            insertStatement.ColumnNames = new AliasedItem(
                new Identifier("test_column"));

            Expression expr = new Expression();
            expr.Left = new IntegerValue(42);
            insertStatement.ColumnValues = new ExpressionItem(expr);
            command.Statement = insertStatement;

            bool changed = false;
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                changed = true;
            }

            Assert.IsTrue(changed);

            string text = command.CommandText;
            Assert.IsTrue(text.StartsWith("INSERT"));
        }

        void CheckExecuteScalar(GlazeFactory glazeFactory, DbConnection connection)
        {
            CheckIntExpression(connection, "1+2", 3);
            CheckIntExpression(connection, "5 % 3", 2);
            CheckIntExpression(connection, "mod(-15, 4)", -3);

            CheckDoubleExpression(connection, ".2", 0.2);
            CheckDoubleExpression(connection, "0.2", 0.2);
            CheckDoubleExpression(connection, "-1.2", -1.2);
            CheckDoubleExpression(connection, "1.2E2", 120);
            CheckDoubleExpression(connection, "0E-10", 0);

            CheckFailingExpression(connection, "select 0/0");
            CheckFailingExpression(connection,
                "select 2003-07-31T00:00:00 - interval '1' month");

            CheckDateTime(glazeFactory, connection);
            CheckDateTimeInterval(connection);

            CheckCurrentTime(connection, "select getdate()");
            CheckCurrentTime(connection, "select now()");
            CheckCurrentTime(connection, "select sysdate from dual");

            CheckStringExpression(connection, "''''", "'");
            CheckStringExpression(connection, "'\"'", "\"");
            CheckStringExpression(connection, "'&'", "&");
            CheckStringExpression(connection, "N'k˘Ú'", "k˘Ú");
            CheckStringExpression(connection, "'A2|45'", "A2|45");
            CheckStringExpression(connection, "'a' || 'b'", "ab");
            CheckStringExpression(connection, "'a' 'b'\n'c'", "abc");
            CheckStringExpression(connection, "N'ûluùouËk˝' || N' ' || N'k˘Ú'",
                "ûluùouËk˝ k˘Ú");
            CheckStringExpression(connection, "N'ûluùouËk˝' \r\n ' kun'",
                "ûluùouËk˝ kun");
            CheckStringExpression(connection, "'zlutoucky ' \r\n N'k˘Ú'",
                "zlutoucky k˘Ú");

            CheckStringExpression(connection, "substring('abcdefgh' from 1 for 2)", "ab");
            CheckStringExpression(connection, "substring(N'k˘Ú' from 2 for 2)", "˘Ú");
            CheckStringExpression(connection, "substring(null from 2)", null);
            CheckStringExpression(connection, "substring('abc' from null)", null);
            CheckStringExpression(connection, "substring('abc' from 1 for null)", null);
            CheckStringExpression(connection, "substring('abc' from 4)", "");
            CheckStringExpression(connection, "substring('abc' from 1 for 5)", "abc");
            CheckStringExpression(connection, "substring('a' || 'b' || 'c' from 1 for 5)", "abc");

            CheckStringFunctions(connection);

            CheckCrossJoin(connection);
	}

        void CheckStringExpression(DbConnection connection, string quoted, string result)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = string.Format("SELECT {0}", quoted);
            object c = command.ExecuteScalar();
            Assert.IsNotNull(c);

            if (result != null)
            {
                Assert.AreEqual(result, c.ToString());
            }
            else
            {
                Assert.AreSame(DBNull.Value, c);
            }
        }

        void CheckIntExpression(DbConnection connection,
            string expression, int result)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = string.Format("select {0}", expression);
            object c = command.ExecuteScalar();
            Assert.IsNotNull(c);
            int d = Convert.ToInt32(c);
            Assert.AreEqual(result, d);
        }

        void CheckDoubleExpression(DbConnection connection,
            string expression, double result)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            if (expression == null)
            {
                throw new ArgumentNullException("expression");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = string.Format("select {0}", expression);
            object c = command.ExecuteScalar();
            Assert.IsNotNull(c);
            double d = Convert.ToDouble(c);
            double eps = Math.Abs(result - d);
            Assert.IsTrue(eps < 0.001);
        }

        void CheckFailingExpression(DbConnection connection, string commandText)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            if (commandText == null)
            {
                throw new ArgumentNullException("commandText");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = commandText;

            bool done = false;
            try
            {
                command.ExecuteScalar();
                done = true;
            }
            catch (Exception)
            {
            }

            Assert.IsFalse(done);
        }

        void CheckStringFunctions(DbConnection connection)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT left('abcde', 3)";
            string s = command.ExecuteScalar() as string;
            Assert.AreEqual("abc", s);

            command = connection.CreateCommand();
            command.CommandText = "SELECT right('abcde', 3)";
            s = command.ExecuteScalar() as string;
            Assert.AreEqual("cde", s);

            CheckSimpleSubstring(connection);
            CheckSubstringPosition(connection);
            CheckSubstringLength(connection);
            CheckComplicatedSubstring(connection);
        }

        void CheckSimpleSubstring(DbConnection connection)
        {
            CleanTestRows(connection, "date1 is null");

            DbCommand command = connection.CreateCommand();
            command.CommandText = "insert into table1(string1) values(null)";
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = "insert into table1(string1) values('abcd')";
            command.ExecuteNonQuery();

            CheckRuntimeSubstring(connection,
                @"select substring(string1 from 1) from table1
where (string1='abcd') or (string1 is null)");
        }

        void CheckSubstringPosition(DbConnection connection)
        {
            CleanTestRows(connection, "date1 is null");

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"insert into table1(number1, string1)
values(null, 'xyz')";
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = @"insert into table1(number1, string1)
values(2, 'xabcd')";
            command.ExecuteNonQuery();

            CheckRuntimeSubstring(connection,
                "select substring(string1 from number1) from table1 where date1 is null");
        }

        void CheckSubstringLength(DbConnection connection)
        {
            CleanTestRows(connection, "date1 is null");

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"insert into table1(number1, string1)
values(null, 'xyz')";
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = @"insert into table1(number1, string1)
values(4, 'xabcd')";
            command.ExecuteNonQuery();

            CheckRuntimeSubstring(connection,
                "select substring(string1 from 2 for number1) from table1 where date1 is null");
        }

        void CheckComplicatedSubstring(DbConnection connection)
        {
            CleanTestRows(connection, "date1 is null");

            DbCommand command = connection.CreateCommand();
            command.CommandText = @"insert into table1(number1,
number1a, string1) values(1, 4, 'abcd')";
            command.ExecuteNonQuery();

            command.CommandText = @"insert into table1(number1,
number1a, string1) values(null, 4, 'abcd')";
            command.ExecuteNonQuery();

            command.CommandText = @"insert into table1(number1,
number1a, string1) values(1, null, 'abcd')";
            command.ExecuteNonQuery();

            command.CommandText = @"insert into table1(number1,
number1a, string1) values(1, 4, null)";
            command.ExecuteNonQuery();

            command.CommandText = @"insert into table1(number1,
number1a, string1) values(null, 4, null)";
            command.ExecuteNonQuery();

            command.CommandText = @"insert into table1(number1,
number1a, string1) values(1, null, null)";
            command.ExecuteNonQuery();

            command.CommandText = @"insert into table1(number1,
number1a, string1) values(null, null, null)";
            command.ExecuteNonQuery();

            command.CommandText = @"select substring(
string1 from number1 for number1a)
from table1
where date1 is null";
            DbDataReader reader = command.ExecuteReader();
            try
            {
                int nullSeen = 0;
                int nonNullSeen = 0;
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        ++nullSeen;
                    }
                    else
                    {
                        ++nonNullSeen;

                        string v = reader.GetString(0);
                        Assert.AreEqual("abcd", v);
                    }
                }

                Assert.AreEqual(6, nullSeen);
                Assert.AreEqual(1, nonNullSeen);
            }
            finally
            {
                reader.Close();
            }
        }

        void CheckRuntimeSubstring(DbConnection connection, string commandText)
        {
            DbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            DbDataReader reader = command.ExecuteReader();
            try
            {
                bool nullSeen = false;
                bool nonNullSeen = false;
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        Assert.IsFalse(nullSeen);
                        nullSeen = true;
                    }
                    else
                    {
                        Assert.IsFalse(nonNullSeen);
                        nonNullSeen = true;

                        string v = reader.GetString(0);
                        Assert.AreEqual("abcd", v);
                    }
                }

                Assert.IsTrue(nullSeen);
                Assert.IsTrue(nonNullSeen);
            }
            finally
            {
                reader.Close();
            }
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

        void CheckDateTime(GlazeFactory glazeFactory, DbConnection connection)
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
            command.Connection = connection;
            command.CommandText = "SELECT 2007-07-18T16:30:00";
            object c = command.ExecuteScalar();
            Assert.IsNotNull(c);

            DateTime dt = (DateTime)c;
            Assert.AreEqual(2007, dt.Year);
            Assert.AreEqual(7, dt.Month);
            Assert.AreEqual(18, dt.Day);
            Assert.AreEqual(16, dt.Hour);
            Assert.AreEqual(30, dt.Minute);
            Assert.AreEqual(0, dt.Second);

            command.CommandText = "SELECT EXTRACT(year FROM 2007-07-18T16:30:00)";
            c = command.ExecuteScalar();
            Assert.AreEqual(2007, c);

            command.CommandText = "SELECT EXTRACT(month FROM 2007-07-18T16:30:00)";
            c = command.ExecuteScalar();
            Assert.AreEqual(7, c);

            command.CommandText = "SELECT EXTRACT(day FROM 2007-07-18T16:30:00)";
            c = command.ExecuteScalar();
            Assert.AreEqual(18, c);

            command.CommandText = "SELECT EXTRACT(hour FROM 2007-07-18T16:30:00)";
            c = command.ExecuteScalar();
            Assert.AreEqual(16, c);

            command.CommandText = "SELECT EXTRACT(minute FROM 2007-07-18T16:30:00)";
            c = command.ExecuteScalar();
            Assert.AreEqual(30, c);

            command.CommandText = "SELECT EXTRACT(second FROM 2007-07-18T16:30:04)";
            c = command.ExecuteScalar();
            Assert.AreEqual(4, c);
        }

        void CheckDateTimeInterval(DbConnection connection)
        {
            CheckDateTimeInterval(connection,
                "SELECT 2007-07-18T16:30:00 - INTERVAL '2' YEAR",
                new DateTime(2005, 7, 18, 16, 30, 0));

            CheckDateTimeInterval(connection,
                "SELECT 2003-07-31 00:00:00 - INTERVAL '100' DAY",
                new DateTime(2003, 4, 22, 0, 0, 0));

            DateTime baseDate = new DateTime(2007, 7, 18, 16, 30, 0);
            CheckDateTimeInterval(connection,
                "SELECT 2007-07-18T16:30:00 + INTERVAL '7' DAY",
                baseDate + new TimeSpan(7, 0, 0, 0));
            CheckDateTimeInterval(connection,
                "select 2007-07-18T16:30:00 - interval '1' second",
                baseDate - new TimeSpan(0, 0, 1));
            CheckDateTimeInterval(connection,
                "select 2007-07-18T16:30:00 - interval '120' second",
                baseDate - new TimeSpan(0, 2, 0));
            CheckDateTimeInterval(connection,
                "select interval '45' minute + 2007-07-18T16:30:00",
                baseDate + new TimeSpan(0, 45, 0));

            CheckDateTimeInterval(connection,
                @"select interval '15' minute +
interval '30' minute + 2007-07-18T16:30:00",
                baseDate + new TimeSpan(0, 45, 0));
            CheckDateTimeInterval(connection,
                @"select interval '15' minute + 2007-07-18T16:30:00 +
interval '30' minute",
                baseDate + new TimeSpan(0, 45, 0));
            CheckDateTimeInterval(connection,
                @"select 2007-07-18T16:30:00 + interval '15' minute +
interval '30' minute",
                baseDate + new TimeSpan(0, 45, 0));
        }

        void CheckDateTimeInterval(DbConnection connection, string commandText,
            DateTime expected)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            if (commandText == null)
            {
                throw new ArgumentNullException("commandText");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = commandText;
            object c = command.ExecuteScalar();
            Assert.IsNotNull(c);

            DateTime dt = (DateTime)c;
            Assert.AreEqual(expected.Year, dt.Year);
            Assert.AreEqual(expected.Month, dt.Month);
            Assert.AreEqual(expected.Day, dt.Day);
            Assert.AreEqual(expected.Hour, dt.Hour);
            Assert.AreEqual(expected.Minute, dt.Minute);
            Assert.AreEqual(expected.Second, dt.Second);
        }

        void CheckCurrentTime(DbConnection connection, string commandText)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("connection");
            }

            if (commandText == null)
            {
                throw new ArgumentNullException("commandText");
            }

            DbCommand command = connection.CreateCommand();
            command.CommandText = commandText;

            DateTime now = DateTime.Now;
            object c = command.ExecuteScalar();
            Assert.IsNotNull(c);

            DateTime dt = (DateTime)c;
            Assert.IsTrue(now <= dt.AddSeconds(1));
            Assert.IsTrue(dt <= now.AddSeconds(command.CommandTimeout + 1));
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
