using System;
using System.Text;
using NUnit.Framework;
using MacroScope;

namespace TestMacroScope
{
    [TestFixture]
    public class MySqlTailorTest
    {
        [Test]
        public void TestConcat()
        {
            CheckSelect("select substr(t1.Major, 1, 5) || t1.Minor from t1",
                @"SELECT CONCAT(substr(t1.Major, 1, 5), t1.Minor)
FROM t1");
        }

        [Test]
        public void TestSelectInterval()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT email, registration_date\r\n");
            expected.Append("FROM users\r\n");
            expected.Append("WHERE registration_date >");
            expected.Append(" (some_date - INTERVAL '1' DAY)");
            CheckSelect(@"select email, registration_date 
from users
where registration_date > some_date - interval '1' day",
                 expected.ToString());

            CheckSelect("select interval '15' minute + interval '30' minute + 2007-07-18T16:30:00",
                 "SELECT INTERVAL '45' MINUTE + TIMESTAMP '2007-07-18 16:30:00'");

            CheckSelect(@"select interval '5' minute + interval '10' minute +
interval '15' minute + 2007-07-18T16:30:00",
                 "SELECT INTERVAL '30' MINUTE + TIMESTAMP '2007-07-18 16:30:00'");
        }

        [Test]
        public void TestInsert()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("INSERT INTO history(libname, modate) VALUES(@libname, ");
            expected.Append("TIMESTAMP '2006-12-31 23:59:58')");
            CheckInsert(@"INSERT INTO history(libname, modate)
VALUES(:libname, 2006-12-31T23:59:58)", expected.ToString());
        }

        [Test]
        public void TestQuotes()
        {
            CheckSelect("SELECT * FROM \"abc\"",
                "SELECT *\r\nFROM abc");

            CheckSelect("select count(*) as \"long title\" from abc",
                "SELECT count(*) AS `long title`\r\nFROM abc");
            CheckSelect("select count(*) as [long title] from abc",
                "SELECT count(*) AS `long title`\r\nFROM abc");
            CheckSelect("select count(*) as `long title` from abc",
                "SELECT count(*) AS `long title`\r\nFROM abc");

            CheckSelect("SELECT * FROM \"create\"", "SELECT *\r\nFROM `create`");
        }

        [Test]
        public void TestTop()
        {
            CheckSelect("SELECT TOP 10 * FROM address",
                "SELECT *\r\nFROM address\r\nLIMIT 10");
            CheckSelect("SELECT *\r\nFROM address\r\nWHERE (rownum <= 1) AND (x > 3)",
                "SELECT *\r\nFROM address\r\nWHERE x > 3\r\nLIMIT 1");
        }

        [Test]
        public void TestFrom()
        {
            CheckSelect("select 1", "SELECT 1");
            CheckSelect("select 1 from dual", "SELECT 1");
            CheckSelect("select 1 from \"dual\"", "SELECT 1\r\nFROM dual");
            CheckSelect("select * from [pathological table]",
                "SELECT *\r\nFROM `pathological table`");
            CheckSelect("select * from `pathological table`",
                "SELECT *\r\nFROM `pathological table`");
        }

        [Test]
        public void TestDateTime()
        {
            CheckSelect("SELECT TIMESTAMP '2007-07-11 16:30:00'",
                "SELECT TIMESTAMP '2007-07-11 16:30:00'");
            CheckSelect("SELECT #2007-07-11 16:30:00#",
                "SELECT TIMESTAMP '2007-07-11 16:30:00'");

            CheckSelect("SELECT GETDATE()", "SELECT CURRENT_TIMESTAMP");
            CheckSelect("SELECT SYSDATE", "SELECT CURRENT_TIMESTAMP");
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
            CheckSelect("SELECT 'a' || 'b'", "SELECT CONCAT('a', 'b')");
            CheckSelect("SELECT 'a' || 'b' || 'c'", "SELECT CONCAT(CONCAT('a', 'b'), 'c')");
        }

        [Test]
        public void TestMod()
        {
            CheckSelect("SELECT 5 % 3", "SELECT 5 % 3");
        }

        [Test]
        public void TestDatetimeExtract()
        {
            CheckSelect("SELECT EXTRACT(month FROM 2007-07-18T16:30:00)",
                "SELECT EXTRACT(MONTH FROM TIMESTAMP '2007-07-18 16:30:00')");
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

            MySqlTailor tailor = new MySqlTailor();
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

            MySqlTailor tailor = new MySqlTailor();
            statement.Traverse(tailor);
            Assert.AreEqual(to, TestUtil.Stringify(statement));
        }
    }
}
