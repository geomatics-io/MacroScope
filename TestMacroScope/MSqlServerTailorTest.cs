using System;
using System.Text;
using NUnit.Framework;
using MacroScope;

namespace TestMacroScope
{
    [TestFixture]
    public class MSqlServerTailorTest
    {
        [Test]
        public void TestConcat()
        {
            CheckSelect("select substr(t1.Major, 1,5) || t2.Minor from t2",
                @"SELECT substr(t1.Major, 1, 5) + t2.Minor
FROM t2");
        }

        [Test]
        public void TestSelectInterval()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT email, registration_date\r\n");
            expected.Append("FROM users\r\n");
            expected.Append("WHERE registration_date > ");
            expected.Append("DATEADD(DAY, -1, some_date)");
            CheckSelect(@"select email, registration_date 
from users
where registration_date > some_date - interval '1' day",
                 expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT *\r\nFROM CronJobs\r\nWHERE DATEADD(");
            expected.Append("SECOND, JOB_INTERVAL, JOB_LASTTIME) < GETDATE()");
            CheckSelect(@"SELECT * FROM CronJobs
WHERE JOB_LASTTIME + JOB_INTERVAL * INTERVAL '1' SECOND < GETDATE()",
                expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT *\r\nFROM CronJobs\r\nWHERE DATEADD(");
            expected.Append("SECOND, 2 * JOB_INTERVAL, JOB_LASTTIME) < GETDATE()");
            CheckSelect(@"SELECT * FROM CronJobs
WHERE JOB_LASTTIME + JOB_INTERVAL * INTERVAL '2' SECOND < GETDATE()",
                expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT *\r\nFROM CronJobs\r\nWHERE DATEADD(");
            expected.Append("SECOND, 3 * JOB_INTERVAL, JOB_LASTTIME) < GETDATE()");
            CheckSelect(@"SELECT * FROM CronJobs
WHERE JOB_LASTTIME + INTERVAL '3' SECOND * JOB_INTERVAL < GETDATE()",
                expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT DATEADD(MINUTE, 45, ");
            expected.Append("CONVERT(datetime, '2007-07-18 16:30:00', 120))");
            CheckSelect("select interval '45' minute + 2007-07-18T16:30:00",
                expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT DATEADD(MINUTE, 15 + 30, ");
            expected.Append("CONVERT(datetime, '2007-07-18 16:30:00', 120))");
            CheckSelect(@"select interval '15' minute +
interval '30' minute +
2007-07-18T16:30:00", expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT DATEADD(MINUTE, (15 + 30) + 60, ");
            expected.Append("CONVERT(datetime, '2007-07-18 16:30:00', 120))");
            CheckSelect(@"select interval '15' minute +
interval '30' minute +
interval '60' minute +
2007-07-18T16:30:00", expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT DATEADD(MINUTE, 30, ");
            expected.Append("DATEADD(MINUTE, 15, ");
            expected.Append("CONVERT(datetime, '2007-07-18 16:30:00', 120)))");
            CheckSelect(@"select interval '15' minute +
2007-07-18T16:30:00 +
interval '30' minute", expected.ToString());
        }

        [Test]
        public void TestInsert()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("INSERT INTO history(libname, modate) ");
            expected.Append("VALUES(@libname, ");
            expected.Append("CONVERT(datetime, '2006-12-31 23:59:58', 120))");
            CheckInsert(@"INSERT INTO history(libname, modate)
VALUES(@libname, 2006-12-31T23:59:58)", expected.ToString());
        }

        [Test]
        public void TestQuotes()
        {
            CheckSelect("SELECT * FROM \"test_table\"",
                "SELECT *\r\nFROM test_table");

            CheckSelect("select count(*) as \"long title\" from test_table",
                "SELECT count(*) AS [long title]\r\nFROM test_table");
            CheckSelect("select count(*) as [long title] from test_table",
                "SELECT count(*) AS [long title]\r\nFROM test_table");
            CheckSelect("select count(*) as `long title` from test_table",
                "SELECT count(*) AS [long title]\r\nFROM test_table");

            CheckSelect("SELECT * FROM \"create\"", "SELECT *\r\nFROM [create]");
        }

        [Test]
        public void TestTop()
        {
            CheckSelect("select a.* from a where RowNum<6",
                "SELECT TOP 5 a.*\r\nFROM a");
            CheckSelect("select a.* from a where 6 > RowNum",
                "SELECT TOP 5 a.*\r\nFROM a");

            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT TOP 10 *\r\n");
            expected.Append("FROM a\r\nWHERE (id >= 100) AND (id < 200)\r\n");
            expected.Append("ORDER BY id");
            CheckSelect(@"select * from a
where (id >= 100) and (id < 200) and (RowNum<=10) order by id",
                expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT TOP 10 id\r\n");
            expected.Append("FROM a\r\nWHERE id <> ALL ( SELECT id\r\nFROM b )");
            CheckSelect(@"select id from a where (id <> all(select id from b))
and (ROWNUM <= 10)", expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT TOP 10 id\r\n");
            expected.Append("FROM a\r\nWHERE id <> ALL ( SELECT TOP 100 id\r\nFROM b )");
            CheckSelect(@"select id from a where (id <> all(select id from b where ROWNUM <= 100))
and (ROWNUM <= 10)", expected.ToString());
        }

        [Test]
        public void TestFrom()
        {
            CheckSelect("select 1", "SELECT 1");
            CheckSelect("select 1 from dual", "SELECT 1");
            CheckSelect("select 1 from \"dual\"", "SELECT 1\r\nFROM dual");
            CheckSelect("select * from `pathological table`",
                "SELECT *\r\nFROM [pathological table]");
        }

        [Test]
        public void TestDateTime()
        {
            CheckSelect("SELECT #2007-07-11 16:30:00#",
                "SELECT CONVERT(datetime, '2007-07-11 16:30:00', 120)");

            CheckSelect("SELECT GETDATE()", "SELECT GETDATE()");
            CheckSelect("SELECT Now()", "SELECT GETDATE()");
            CheckSelect("SELECT sysdate", "SELECT GETDATE()");
        }

        [Test]
        public void TestVariable()
        {
            CheckSelect("Select * from inventory where updated >= @threshold",
                "SELECT *\r\nFROM inventory\r\nWHERE updated >= @threshold");
            CheckSelect("Select * from inventory where updated >= :threshold",
                "SELECT *\r\nFROM inventory\r\nWHERE updated >= @threshold");
        }

        [Test]
        public void TestStringExpression()
        {
            CheckSelect("SELECT N'kůň'", "SELECT N'kůň'");
            CheckSelect("SELECT 'a' || 'b'", "SELECT 'a' + 'b'");

            CheckSelect("select substring('abc' from 4)",
                "SELECT substring('abc', 4, (LEN('abc') + 1) - 4)");

            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT CASE\r\n");
            expected.Append("WHEN colname IS NOT NULL THEN ");
            expected.Append("substring(colname, 2, (LEN(colname) + 1) - 2)\r\n");
            expected.Append("ELSE NULL\r\nEND\r\n");
            expected.Append("FROM tablename");
            CheckSelect("SELECT substring(colname from 2) from tablename",
                expected.ToString());

            CheckSelect("SELECT substring(null from 2)",
                "SELECT NULL");
        }

        [Test]
        public void TestMod()
        {
            CheckSelect("SELECT 5 % 3", "SELECT 5 % 3");
            CheckSelect("SELECT mod(5, 3)", "SELECT 5 % 3");
            CheckSelect("SELECT MOD(7, MOD(5, 3))\r\nFROM dual", "SELECT 7 % (5 % 3)");
            CheckSelect("SELECT MOD(MOD(7, 5), 3)\r\nFROM dual", "SELECT (7 % 5) % 3");
        }

        [Test]
        public void TestCase()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT CASE address_id\r\n");
            expected.Append("WHEN 1 THEN 'one'\r\nELSE 'other'\r\n");
            expected.Append("END\r\nFROM address");
            CheckSelect(@"SELECT CASE address_id
WHEN 1 THEN 'one'
ELSE 'other'
END CASE
FROM address", expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT CASE\r\n");
            expected.Append("WHEN street IS NOT NULL THEN ");
            expected.Append("(((city + ', ') + street) + ' ') + num\r\n");
            expected.Append("ELSE city + num\r\n");
            expected.Append("END\r\nFROM address");
            CheckSelect(@"SELECT CASE
WHEN street is not null THEN city || ', ' || street || ' ' || num
ELSE city || num
END CASE
FROM address", expected.ToString());
        }

        [Test]
        public void TestDatetimeExtract()
        {
            CheckSelect("SELECT EXTRACT(month FROM 2007-07-18T16:30:00)",
                "SELECT DATEPART(MONTH, CONVERT(datetime, '2007-07-18 16:30:00', 120))");
        }

        [Test]
        public void TestNamer()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT address_id\r\nFROM address\r\n");
            expected.Append("WHERE (@x000 <= address_id) AND (address_id < @x001)");
            CheckSelect(@"SELECT address_id FROM address
WHERE ?<=address_id and address_id<?", expected.ToString());
        }

        [Test]
        public void TestTailorError()
        {
            CheckTailorError("select a.* from a where RowNum < n");
        }

        void CheckSelect(string idempotent)
        {
            CheckSelect(idempotent, idempotent);
        }

        void CheckSelect(string from, string to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            IStatement statement = Factory.CreateStatement(from);
            Assert.IsNotNull(statement);

            MSqlServerTailor tailor = new MSqlServerTailor();
            statement.Traverse(tailor);
            Assert.AreEqual(to, TestUtil.Stringify(statement));
        }

        void CheckInsert(string from, string to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            IStatement statement = Factory.CreateStatement(from);
            Assert.IsNotNull(statement);
            Assert.IsInstanceOfType(typeof(InsertStatement), statement);

            MSqlServerTailor tailor = new MSqlServerTailor();
            statement.Traverse(tailor);
            Assert.AreEqual(to, TestUtil.Stringify(statement));
        }

        void CheckTailorError(string tooHard)
        {
            if (tooHard == null)
            {
                throw new ArgumentNullException("tooHard");
            }

            IStatement statement = Factory.CreateStatement(tooHard);
            Assert.IsNotNull(statement);

            try
            {
                MSqlServerTailor tailor = new MSqlServerTailor();
                statement.Traverse(tailor);
                Assert.Fail();
            }
            catch (InvalidOperationException exception)
            {
                Assert.IsNotNull(exception);
            }
        }
    }
}
