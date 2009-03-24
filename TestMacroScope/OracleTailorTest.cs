using System;
using System.Text;
using NUnit.Framework;
using MacroScope;

namespace TestMacroScope
{
    [TestFixture]
    public class OracleTailorTest
    {
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

            expected = new StringBuilder();
            expected.Append("SELECT email, registration_date\r\n");
            expected.Append("FROM users\r\n");
            expected.Append("WHERE registration_date >");
            expected.Append(" (some_date - INTERVAL '-1' DAY)");
            CheckSelect(@"select email, registration_date 
from users
where registration_date > some_date - interval -'1' day",
                 expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT TIMESTAMP '2003-07-31 00:00:00' - ");
            expected.Append("INTERVAL '100' DAY(3)\r\n");
            expected.Append("FROM dual");
            CheckSelect("SELECT 2003-07-31 00:00:00 - INTERVAL '100' DAY",
                expected.ToString());
        }

        [Test]
        public void TestInsert()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("INSERT INTO history(libname, modate) VALUES(:libname, ");
            expected.Append("TIMESTAMP '2006-12-31 23:59:58')");
            CheckInsert(@"INSERT INTO history(libname, modate)
VALUES(@libname, 2006-12-31T23:59:58)", expected.ToString());
        }

        [Test]
        public void TestQuotes()
        {
            CheckSelect("SELECT * FROM \"abc\"",
                "SELECT *\r\nFROM abc");

            CheckSelect("select count(*) as \"long title\" from abc",
                "SELECT count(*) AS \"long title\"\r\nFROM abc");
            CheckSelect("select count(*) as [long title] from abc",
                "SELECT count(*) AS \"long title\"\r\nFROM abc");
            CheckSelect("select count(*) as `long title` from abc",
                "SELECT count(*) AS \"long title\"\r\nFROM abc");

            CheckSelect("SELECT * FROM \"create\"", "SELECT *\r\nFROM \"create\"");
        }

        [Test]
        public void TestTop()
        {
            CheckSelect("SELECT TOP 10 * FROM address",
                "SELECT *\r\nFROM address\r\nWHERE rownum <= 10");
            CheckSelect("SELECT TOP 1 * FROM address WHERE x>3",
                "SELECT *\r\nFROM address\r\nWHERE (rownum <= 1) AND (x > 3)");
        }

        [Test]
        public void TestFrom()
        {
            CheckSelect("select 1", "SELECT 1\r\nFROM dual");
            CheckSelect("select 1 from dual", "SELECT 1\r\nFROM dual");
            CheckSelect("select 1 from \"dual\"", "SELECT 1\r\nFROM dual");
        }

        [Test]
        public void TestDateTime()
        {
            CheckSelect("SELECT TIMESTAMP '2007-07-11 16:30:00'",
                "SELECT TIMESTAMP '2007-07-11 16:30:00'\r\nFROM dual");
            CheckSelect("SELECT #2007-07-11 16:30:00#",
                "SELECT TIMESTAMP '2007-07-11 16:30:00'\r\nFROM dual");

            CheckSelect("SELECT GETDATE()", "SELECT SYSDATE\r\nFROM dual");
            CheckSelect("SELECT Now()", "SELECT SYSDATE\r\nFROM dual");
            CheckSelect("SELECT SYSDATE", "SELECT SYSDATE\r\nFROM dual");
        }

        [Test]
        public void TestVariable()
        {
            CheckSelect("Select * from inventory where updated >= @threshold",
                "SELECT *\r\nFROM inventory\r\nWHERE updated >= :threshold");
            CheckSelect("Select * from inventory where updated >= :threshold",
                "SELECT *\r\nFROM inventory\r\nWHERE updated >= :threshold");
        }

        [Test]
        public void TestStringExpression()
        {
            CheckSelect("SELECT N'kůň'", "SELECT N'kůň'\r\nFROM dual");
            CheckSelect("SELECT 'a' || 'b'", "SELECT 'a' || 'b'\r\nFROM dual");
            CheckSelect("select substring('abc' from 4)",
                "SELECT SUBSTR('abc', 4)\r\nFROM dual");
        }

        [Test]
        public void TestMod()
        {
            CheckSelect("SELECT 5 % 3", "SELECT MOD(5, 3)\r\nFROM dual");
            CheckSelect("SELECT mod(5, 3)", "SELECT mod(5, 3)\r\nFROM dual");
            CheckSelect("SELECT 7 % (5 % 3)", "SELECT MOD(7, MOD(5, 3))\r\nFROM dual");
            CheckSelect("SELECT (7 % 5) % 3", "SELECT MOD(MOD(7, 5), 3)\r\nFROM dual");
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
            expected.Append("(((city || ', ') || street) || ' ') || num\r\n");
            expected.Append("ELSE city || num\r\n");
            expected.Append("END\r\nFROM address");
            CheckSelect(@"SELECT CASE
WHEN street is not null THEN city || ', ' || street || ' ' || num
ELSE city || num
END CASE
FROM address", expected.ToString());
        }

        [Test]
        public void TestLeft()
        {
            CheckSelect("select left('abcde', 3)",
                "SELECT SUBSTR('abcde', 1, 3)\r\nFROM dual");
        }

        [Test]
        public void TestRight()
        {
            CheckSelect("select RIGHT('abcde', 3)",
                "SELECT SUBSTR('abcde', -1 * 3)\r\nFROM dual");
        }

        [Test]
        public void TestDatetimeExtract()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT EXTRACT(MONTH FROM TIMESTAMP '2007-07-18 16:30:00')\r\n");
            expected.Append("FROM dual");
            CheckSelect("SELECT EXTRACT(month FROM 2007-07-18T16:30:00)",
                expected.ToString());
        }

        [Test]
        public void TestNamer()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT address_id\r\nFROM address\r\n");
            expected.Append("WHERE (:x000 <= address_id) AND (address_id < :x001)");
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

            OracleTailor tailor = new OracleTailor();
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

            OracleTailor tailor = new OracleTailor();
            statement.Traverse(tailor);
            Assert.AreEqual(to, TestUtil.Stringify(statement));
        }
    }
}
