using System;
using System.Text;
using NUnit.Framework;
using MacroScope;

namespace TestMacroScope
{
    [TestFixture]
    public class MAccessTailorTest
    {
        [Test]
        public void TestSelectInterval()
        {
            CheckSelect("SELECT 2007-07-18T16:30:00 + INTERVAL '7' DAY",
                "SELECT DATEADD(\"d\", 7, #2007-07-18 16:30:00#)"); 
   
            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT email, registration_date\r\n");
            expected.Append("FROM users\r\n");
            expected.Append("WHERE registration_date > ");
            expected.Append("DATEADD(\"d\", -1, some_date)");
            CheckSelect(@"select email, registration_date 
from users
where registration_date > some_date - interval '1' day",
                 expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT *\r\nFROM CronJobs\r\n");
            expected.Append("WHERE DATEADD(\"s\", JOB_INTERVAL, JOB_LASTTIME) < Now()");
            CheckSelect(@"SELECT * FROM CronJobs
WHERE JOB_LASTTIME + JOB_INTERVAL * INTERVAL '1' SECOND < GETDATE()",
                expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT *\r\nFROM CronJobs\r\n");
            expected.Append("WHERE DATEADD(\"s\", 2 * JOB_INTERVAL, JOB_LASTTIME) < Now()");
            CheckSelect(@"SELECT * FROM CronJobs
WHERE JOB_LASTTIME + JOB_INTERVAL * INTERVAL '2' SECOND < GETDATE()",
                expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT *\r\nFROM CronJobs\r\n");
            expected.Append("WHERE DATEADD(\"s\", 3 * JOB_INTERVAL, JOB_LASTTIME) < Now()");
            CheckSelect(@"SELECT * FROM CronJobs
WHERE JOB_LASTTIME + INTERVAL '3' SECOND * JOB_INTERVAL < GETDATE()",
                expected.ToString());

            CheckSelect("select interval '45' minute + 2007-07-18T16:30:00",
                "SELECT DATEADD(\"n\", 45, #2007-07-18 16:30:00#)");
            CheckSelect(@"select interval '15' minute +
interval '30' minute +
2007-07-18T16:30:00",
                "SELECT DATEADD(\"n\", 15 + 30, #2007-07-18 16:30:00#)");
            CheckSelect(@"select interval '15' minute +
interval '30' minute +
interval '60' minute +
2007-07-18T16:30:00",
                "SELECT DATEADD(\"n\", (15 + 30) + 60, #2007-07-18 16:30:00#)");
            CheckSelect(@"select interval '15' minute +
2007-07-18T16:30:00 +
interval '30' minute",
                "SELECT DATEADD(\"n\", 30, DATEADD(\"n\", 15, #2007-07-18 16:30:00#))");
        }

        [Test]
        public void TestInsert()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("INSERT INTO history(libname, modate) ");
            expected.Append("VALUES(@libname, #2006-12-31 23:59:58#)");
            CheckInsert(@"INSERT INTO history(libname, modate)
VALUES(@libname, 2006-12-31T23:59:58)", expected.ToString());

            expected = new StringBuilder();
            expected.Append("INSERT INTO test_table(second_column) ");
            expected.Append("VALUES(9)");
            CheckInsert(@"insert into test_table(first_column, second_column)
values(default, 9)", expected.ToString());

            expected = new StringBuilder();
            expected.Append("INSERT INTO test_table(first_column) ");
            expected.Append("VALUES(10)");
            CheckInsert(@"insert into test_table(first_column, second_column)
values(10, default)", expected.ToString());

            CheckInsert(@"insert into test_table(a, b, c, d)
values(default, default, 1, default)", "INSERT INTO test_table(c) VALUES(1)");
        }

        [Test]
        public void TestQuotes()
        {
            CheckSelect("SELECT * FROM \"abc\"",
                "SELECT *\r\nFROM abc");
            CheckSelect("SELECT * FROM [abc]",
                "SELECT *\r\nFROM abc");

            CheckSelect("SELECT * FROM \"create\"", "SELECT *\r\nFROM `create`");
        }

        [Test]
        public void TestJoin()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT TOP 10000 address.address_id, ");
            expected.Append("building.number_type, ");
            expected.Append("building.number_value, ");
            expected.Append("settlement.name AS settlement_name, ");
            expected.Append("village.name AS village_name\r\n");
            expected.Append("FROM ((address ");
            expected.Append("INNER JOIN building ");
            expected.Append("ON (address.building_id = ");
            expected.Append("building.building_id)) ");
            expected.Append("INNER JOIN settlement ");
            expected.Append("ON (building.settlement_id = settlement.settlement_id)) ");
            expected.Append("LEFT JOIN village ");
            expected.Append("ON (settlement.village_id = village.village_id)");
            CheckSelect(@"SELECT TOP 10000 address.address_id,
building.number_type, building.number_value, settlement.name AS settlement_name,
village.name AS village_name
FROM address
INNER JOIN building ON address.building_id = building.building_id
INNER JOIN settlement ON building.settlement_id = settlement.settlement_id
LEFT OUTER JOIN village ON settlement.village_id = village.village_id",
                expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT address.address_id, ");
            expected.Append("building.number_type, building.number_value\r\n");
            expected.Append("FROM address, building");
            CheckSelect(@"SELECT address.address_id,
building.number_type, building.number_value
FROM address
CROSS JOIN building", expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT address.address_id, ");
            expected.Append("building.number_type, building.number_value, ");
            expected.Append("settlement.name AS settlement_name, ");
            expected.Append("village.name AS village_name\r\n");
            expected.Append("FROM address, building, settlement, village");
            CheckSelect(@"SELECT address.address_id,
building.number_type, building.number_value, settlement.name AS settlement_name,
village.name AS village_name
FROM address CROSS JOIN building CROSS JOIN settlement CROSS JOIN village",
                expected.ToString());
        }

        [Test]
        public void TestTop()
        {
            CheckSelect("select a.* from a where RowNum<6",
                "SELECT TOP 5 a.*\r\nFROM a");
            CheckSelect("select a.* from a where 6 > RowNum",
                "SELECT TOP 5 a.*\r\nFROM a");

            CheckSelect("select * from a where (id>=100) and (id<200) and (10>=RowNum)",
                "SELECT TOP 10 *\r\nFROM a\r\nWHERE (id >= 100) AND (id < 200)");
        }

        [Test]
        public void TestFrom()
        {
            CheckSelect("select 1", "SELECT 1");
            CheckSelect("select 1 from dual", "SELECT 1");
            CheckSelect("select 1 from \"dual\"", "SELECT 1\r\nFROM dual");
        }

        [Test]
        public void TestDateTime()
        {
            CheckSelect("SELECT #2007-07-11 16:30:00#");
            CheckSelect("SELECT TIMESTAMP '2007-07-11 16:30:00'",
                "SELECT #2007-07-11 16:30:00#");

            IStatement statement = Factory.CreateStatement(
                "select * from inventory where (article=@x) and (modate>@last)");
            Assert.IsNotNull(statement);

            DateTime dateTime = new DateTime(2007, 7, 11, 16, 30, 0);
            MAccessTailor tailor = new MAccessTailor();
            tailor.AddDate("@LAST", dateTime);
            statement.Traverse(tailor);

            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT *\r\nFROM inventory\r\n");
            expected.Append("WHERE (article = @x) AND ");
            expected.Append("(modate > #2007-07-11 16:30:00#)");
            Assert.AreEqual(expected.ToString(), TestUtil.Stringify(statement));

            CheckSelect("SELECT GETDATE()", "SELECT Now()");
            CheckSelect("SELECT Now()", "SELECT Now()");
            CheckSelect("SELECT sysdate", "SELECT Now()");
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
            CheckSelect("SELECT N'kůň'", "SELECT \"kůň\"");
            CheckSelect("SELECT 'a' || 'b'", "SELECT 'a' + 'b'");

            CheckSelect("select substring('abc' from 4)",
                "SELECT Mid('abc', 4, (Len('abc') + 1) - 4)");

            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT Iif(IsNull(first_column), NULL, ");
            expected.Append("Mid(string_column, 2, first_column))\r\n");
            expected.Append("FROM test_table");
            CheckSelect(@"select substring(string_column from 2 for first_column)
from test_table", expected.ToString());
        }

        [Test]
        public void TestMod()
        {
            CheckSelect("SELECT 5 % 3", "SELECT 5 MOD 3");
            CheckSelect("SELECT mod(5, 3)", "SELECT 5 MOD 3");
            CheckSelect("SELECT MOD(7, MOD(5, 3))\r\nFROM dual", "SELECT 7 MOD (5 MOD 3)");
            CheckSelect("SELECT MOD(MOD(7, 5), 3)\r\nFROM dual", "SELECT (7 MOD 5) MOD 3");
        }

        [Test]
        public void TestCase()
        {
            CheckSelect(@"SELECT CASE address_id
WHEN 1 THEN 'one'
ELSE 'other'
END CASE
FROM address", "SELECT Switch(address_id = 1, 'one', 1 = 1, 'other')\r\nFROM address");

            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT Switch(street IS NOT NULL, ");
            expected.Append("(((city + ', ') + street) + ' ') + num, ");
            expected.Append("1 = 1, city + num)\r\n");
            expected.Append("FROM address");
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
                "SELECT MONTH(#2007-07-18 16:30:00#)");
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
        public void TestAlias()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT count(*) AS c, name\r\n");
            expected.Append("FROM settlement\r\nGROUP BY name\r\n");
            expected.Append("ORDER BY count(*) DESC");
            CheckSelect(@"SELECT count(*) as c, name
FROM settlement group by name order by c desc", expected.ToString());
        }

        [Test]
        public void TestTailorError()
        {
            CheckTailorError(@"SELECT min(settlement_id) as m, max(settlement_id) as m
FROM settlement");
            CheckTailorError("insert into test_table(first_column) values(default)");
            CheckTailorError("update test_table set first_column=default");
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

            MAccessTailor tailor = new MAccessTailor();
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

            MAccessTailor tailor = new MAccessTailor();
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
                MAccessTailor tailor = new MAccessTailor();
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
