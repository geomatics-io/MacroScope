using System;
using System.Text;
using Antlr.Runtime;
using NUnit.Framework;
using MacroScope;

namespace TestMacroScope
{
    [TestFixture]
    public class MacroScopeParserTest
    {
        [Test]
        public void TestSubExpression()
        {
            CheckSubExpression("1");
            CheckSubExpression("-1");
            CheckSubExpression("a");
            CheckSubExpression("a.b.c");
            CheckSubExpression("f( x )", "f(x)");
            CheckSubExpression("''''''");
            CheckSubExpression("'1''1''2'''''");

            StringBuilder expected = new StringBuilder();
            expected.Append("CASE c.Level\r\n");
            expected.Append("WHEN 'A' THEN 'Advanced'\r\n");
            expected.Append("WHEN 'B' THEN 'Beginner'\r\n");
            expected.Append("WHEN 'C' THEN 'Certification'\r\n");
            expected.Append("WHEN 'G' THEN 'Graduate'\r\n");
            expected.Append("WHEN 'I' THEN 'Intermediate'\r\n");
            expected.Append("WHEN 'P' THEN 'Post-graduate'\r\n");
            expected.Append("WHEN 'U' THEN 'Undergraduate'\r\n");
            expected.Append("WHEN 'X' THEN 'Unknown/Indeterminate'\r\n");
            expected.Append("ELSE 'Other'\r\nEND");
            CheckSubExpression(@"CASE c.Level
WHEN 'A' THEN 'Advanced'
WHEN 'B' THEN 'Beginner'
WHEN 'C' THEN 'Certification'
WHEN 'G' THEN 'Graduate'
WHEN 'I' THEN 'Intermediate'
WHEN 'P' THEN 'Post-graduate'
WHEN 'U' THEN 'Undergraduate'
WHEN 'X' THEN 'Unknown/Indeterminate'
ELSE 'Other'
END", expected.ToString());

            expected = new StringBuilder();
            expected.Append("CASE\r\nWHEN NULL IS NULL THEN 'one'\r\n");
            expected.Append("ELSE 'other'\r\nEND");
            CheckSubExpression(@"CASE WHEN null is null THEN 'one'
ELSE 'other' END", expected.ToString());

            CheckSubExpression("cast(c as int)", "CAST(c AS int)");
            CheckSubExpression("cast( '22-Aug-2003' AS varchar2(30) )",
                "CAST('22-Aug-2003' AS varchar2(30))");
            CheckSubExpression("CAST(xcoord AS decimal(5, 2))");

            CheckSubExpression("interval '100' day(3)", "INTERVAL '100' DAY(3)");
        }

        void CheckSubExpression(string idempotent)
        {
            CheckSubExpression(idempotent, idempotent);
        }

        void CheckSubExpression(string from, string to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            MacroScopeParser parser = Factory.CreateParser(from);
            IExpression expression = parser.subExpression();
            Assert.IsNotNull(expression);
            Assert.AreEqual(to, TestUtil.Stringify(expression));
        }

        [Test]
        public void TestExpression()
        {
            CheckExpression("1");
            CheckExpression("-1");
            CheckExpression("-(-1)");
            CheckExpression("+1", "1");
            CheckExpression("a + b * c - d + e / f % g * h",
                "((a + (b * c)) - d) + (((e / f) % g) * h)");
        }

        void CheckExpression(string idempotent)
        {
            CheckExpression(idempotent, idempotent);
        }

        void CheckExpression(string from, string to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            MacroScopeParser parser = Factory.CreateParser(from);
            IExpression expression = parser.expression();
            Assert.IsNotNull(expression);
            Assert.AreEqual(to, TestUtil.Stringify(expression));
        }

        [Test]
        public void TestSelectExpr()
        {
            CheckSelect("select 1", "SELECT 1");
            CheckSelect("select +1", "SELECT 1");
            CheckSelect("select -1", "SELECT -1");
            CheckSelect("select 1.5", "SELECT 1.5");
            CheckSelect("select 1e4", "SELECT 10000");
            CheckSelect("select 3e-2", "SELECT 0.03");
            CheckSelect("select 0xa", "SELECT 10");
            CheckSelect("select 1 + 2", "SELECT 1 + 2");
            CheckSelect("select (1 + 2)", "SELECT 1 + 2");
            CheckSelect("select (1 * 2) + (3 * 4)", "SELECT (1 * 2) + (3 * 4)");
            CheckSelect("select (1 + 2) * (3 + 4)", "SELECT (1 + 2) * (3 + 4)");
            CheckSelect("select (((1 + 2)))", "SELECT 1 + 2");
            CheckSelect("select 42 as answer", "SELECT 42 AS answer");
            CheckSelect("SELECT #2007-07-11 16:30:00#");
            CheckSelect("SELECT 2007-07-11T16:30:00",
                "SELECT #2007-07-11 16:30:00#");
            CheckSelect("SELECT 2007-07-11 16:30:00",
                "SELECT #2007-07-11 16:30:00#");
            CheckSelect("select 42 as \"The Answer\"", "SELECT 42 AS \"The Answer\"");
            CheckSelect("SELECT [column name]");
            CheckSelect("SELECT sum(amount) AS \"bottom line\"\r\nFROM t");
            CheckSelect("SELECT N'kůň'");
            CheckSelect("SELECT n'kůň'", "SELECT N'kůň'");

            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT Customers.CustomerID, Customers.CompanyName, ");
            expected.Append("Customers.Country, CASE Country\r\n");
            expected.Append("WHEN 'Germany' THEN '0049 ' + Phone\r\n");
            expected.Append("WHEN 'Mexico' THEN 'Fiesta ' + Phone\r\n");
            expected.Append("WHEN 'UK' THEN 'Black Pudding (Yuk!) ' + Phone\r\n");
            expected.Append("ELSE Phone\r\nEND AS Phone\r\nFROM Customers");
            CheckSelect(@"SELECT 
 Customers.CustomerID
 , Customers.CompanyName
 , Customers.Country
 , CASE Country
    WHEN 'Germany' 
     THEN '0049 ' + Phone
    WHEN 'Mexico'
     THEN 'Fiesta ' + Phone
    WHEN 'UK'
     THEN 'Black Pudding (Yuk!) ' + Phone
     ELSE Phone
     END AS Phone
FROM 
 Customers", expected.ToString());

            SelectStatement statement = Factory.CreateStatement("select 1 * 2 + 3")
                as SelectStatement;
            Assert.IsNotNull(statement);

            QueryExpression queryExpression = statement.SingleQueryExpression;
            Assert.IsNotNull(queryExpression);
            Assert.IsNull(queryExpression.Top);
            Assert.IsFalse(queryExpression.Distinct);

            AliasedItem item = queryExpression.SelectItems;
            Assert.IsNotNull(item);
            Assert.IsFalse(item.HasNext);

            Expression expression = item.Item as Expression;
            Assert.IsNotNull(expression);

            ExpressionOperator expressionOperator = expression.Operator;
            Assert.IsNotNull(expressionOperator);
            Assert.AreEqual("+", expressionOperator.Value);

            CheckSelect("select 18/2/3", "SELECT (18 / 2) / 3");
        }

        [Test]
        public void TestSelectEdge()
        {
            CheckSelect("select*from\"test_table\"", "SELECT *\r\nFROM \"test_table\"");
            CheckSelect("SELECT * FROM \"create\"", "SELECT *\r\nFROM \"create\"");
        }

        [Test]
        public void TestInsert()
        {
            CheckInsert("INSERT INTO t(a, b, c) VALUES(@a, @b, 1)",
                "INSERT INTO t(a, b, c) VALUES(@a, @b, 1)");
            CheckInsert("insert \"table\" (created, updated) values (default, null)",
                "INSERT INTO \"table\"(created, updated) VALUES(DEFAULT, NULL)");
        }

        [Test]
        public void TestUpdate()
        {
            CheckUpdate("update coordinates set x = -y, y = -x",
                "UPDATE coordinates SET x = -y, y = -x");

            StringBuilder expected = new StringBuilder();
            expected.Append("UPDATE Person SET FirstName = 'Nina'\r\n");
            expected.Append("WHERE LastName = 'Rasmussen'");
            CheckUpdate(@"UPDATE Person SET FirstName = 'Nina'
WHERE LastName = 'Rasmussen'", expected.ToString());
        }

        [Test]
        public void TestDelete()
        {
            CheckDelete("delete from statements",
                "DELETE FROM statements");
            CheckDelete("delete statements where predicate='says'",
                "DELETE FROM statements\r\nWHERE predicate = 'says'");
        }

        [Test]
        public void TestSelectItems()
        {
            CheckSelect("SELECT [count] = 1 + 2",
                "SELECT 1 + 2 AS [count]");
            CheckSelect("select address_id from address",
                "SELECT address_id\r\nFROM address");
            CheckSelect("select address_id, street_id from address",
                "SELECT address_id, street_id\r\nFROM address");
            CheckSelect("select address.* from address",
                "SELECT address.*\r\nFROM address");
            CheckSelect("select address.address_id from address",
                "SELECT address.address_id\r\nFROM address");
            CheckSelect("select address.address_id, street_id from address",
                "SELECT address.address_id, street_id\r\nFROM address");
            CheckSelect(@"select address.address_id, x, y from address",
                "SELECT address.address_id, x, y\r\nFROM address");

            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT Originator AS Author, ");
            expected.Append("RelativeConfidence AS Confidence\r\n");
            expected.Append("FROM address_tags");
            CheckSelect(@"select Author=Originator,
Confidence=RelativeConfidence from address_tags", expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT ( SELECT count(*)\r\nFROM t1 ), ");
            expected.Append("( SELECT count(*)\r\nFROM t2 )");
            CheckSelect(@"select (select count(*) from t1),
                (select count(*) from t2)", expected.ToString());
        }

        [Test]
        public void TestSelectInterval()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT email, registration_date\r\n");
            expected.Append("FROM users\r\n");
            expected.Append("WHERE registration_date > (some_date - INTERVAL '1' DAY)");
            CheckSelect(@"select email, registration_date 
from users
where registration_date > some_date - interval '1' day",
                 expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT email, registration_date\r\n");
            expected.Append("FROM users\r\n");
            expected.Append("WHERE registration_date > (some_date - INTERVAL '-7' DAY)");
            CheckSelect(@"select email, registration_date 
from users
where registration_date > some_date - interval '-7' day",
                 expected.ToString());
        }

        [Test]
        public void TestSubTableSource()
        {
            CheckSubTableSource("(SELECT c\r\nFROM t\r\n) AS a",
                "( SELECT c\r\nFROM t ) a");
            CheckSubTableSource("t.c a");
            CheckSubTableSource("t.c AS a", "t.c a");
            CheckSubTableSource("t.c AS \"a\"", "t.c \"a\"");
            CheckSubTableSource("t.c AS [a]", "t.c [a]");
            CheckSubTableSource("max (id)", "max(id)");
            CheckSubTableSource("MassageTables() AS found",
                "MassageTables() found");
        }

        void CheckSubTableSource(string idempotent)
        {
            CheckSubTableSource(idempotent, idempotent);
        }

        void CheckSubTableSource(string from, string to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            MacroScopeParser parser = Factory.CreateParser(from);
            Table table = parser.subTableSource();
            Assert.IsNotNull(table);

            Assert.AreEqual(to, TestUtil.Stringify(table));
        }

        [Test]
        public void TestJoinedTable()
        {
            CheckJoinedTable("INNER JOIN t2 ON a=b",
                "INNER JOIN t2 ON a = b");
            CheckJoinedTable("INNER JOIN t2 ON t1.id=t2.id",
                "INNER JOIN t2 ON t1.id = t2.id");
        }

        void CheckJoinedTable(string idempotent)
        {
            CheckJoinedTable(idempotent, idempotent);
        }

        void CheckJoinedTable(string from, string to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            MacroScopeParser parser = Factory.CreateParser(from);
            Table table = parser.joinedTable();
            Assert.IsNotNull(table);

            Assert.AreEqual(to, TestUtil.Stringify(table));
        }

        [Test]
        public void TestSelectFrom()
        {
            CheckSelect("select * from area", "SELECT *\r\nFROM area");
            CheckSelect("select a from b JOIN c ON d = e",
                "SELECT a\r\nFROM b INNER JOIN c ON d = e");

            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT TOP 10000 address.address_id, ");
            expected.Append("building.number_type, ");
            expected.Append("building.number_value, ");
            expected.Append("settlement.name AS settlement_name, ");
            expected.Append("village.name AS village_name\r\n");
            expected.Append("FROM address ");
            expected.Append("INNER JOIN building ");
            expected.Append("ON address.building_id = building.building_id ");
            expected.Append("INNER JOIN settlement ");
            expected.Append("ON building.settlement_id = settlement.settlement_id ");
            expected.Append("LEFT JOIN village ");
            expected.Append("ON settlement.village_id = village.village_id");
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
            expected.Append("building.number_type, ");
            expected.Append("building.number_value, ");
            expected.Append("settlement.name AS settlement_name, ");
            expected.Append("village.name AS village_name\r\n");
            expected.Append("FROM (address ");
            expected.Append("INNER JOIN building ");
            expected.Append("ON address.building_id = building.building_id) ");
            expected.Append("INNER JOIN settlement ");
            expected.Append("ON building.settlement_id = settlement.settlement_id, ");
            expected.Append("village\r\n");
            expected.Append("WHERE settlement.village_id = village.village_id");
            CheckSelect(@"SELECT address.address_id,
building.number_type, building.number_value, settlement.name AS settlement_name,
village.name AS village_name
FROM (address
INNER JOIN building ON address.building_id = building.building_id)
INNER JOIN settlement ON building.settlement_id = settlement.settlement_id,
village WHERE settlement.village_id = village.village_id", expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT address.address_id, ");
            expected.Append("building.number_type, ");
            expected.Append("building.number_value, ");
            expected.Append("settlement.name AS settlement_name, ");
            expected.Append("village.name AS village_name\r\n");
            expected.Append("FROM address, building, settlement, village\r\n");
            expected.Append("WHERE ((address.building_id = ");
            expected.Append("building.building_id) ");
            expected.Append("AND (building.settlement_id = settlement.settlement_id)) ");
            expected.Append("AND (settlement.village_id = village.village_id)");

            CheckSelect(@"SELECT address.address_id,
building.number_type, building.number_value, settlement.name settlement_name,
village.name village_name
FROM address, building, settlement, village
WHERE (address.building_id = building.building_id) AND
    (building.settlement_id = settlement.settlement_id) AND
    (settlement.village_id = village.village_id)",
                expected.ToString());

            CheckSelect("SELECT t1.*, t2.* FROM t1 CROSS JOIN t2",
                "SELECT t1.*, t2.*\r\nFROM t1 CROSS JOIN t2");

            expected = new StringBuilder();
            expected.Append("SELECT r.*, s.*, u.*, v.*\r\n");
            expected.Append("FROM r CROSS JOIN s, ");
            expected.Append("u INNER JOIN v ON u.id = v.id");
            CheckSelect(@"SELECT r.*, s.*, u.*, v.* FROM r CROSS JOIN s,
u JOIN v ON u.id = v.id", expected.ToString());

            CheckSelect("SELECT [column name]\r\nFROM [strange table]");
            CheckSelect("SELECT *\r\nFROM address\r\nWHERE address_id = ?");
        }

        [Test]
        public void TestSelectItem()
        {
            MacroScopeParser parser = Factory.CreateParser("*");
            AliasedItem selectItem = parser.selectItem();
            Assert.IsInstanceOfType(typeof(Wildcard), selectItem.Item);

            parser = Factory.CreateParser("Author = Originator");
            selectItem = parser.selectItem();
            Assert.IsNotNull(selectItem);
            Identifier alias = selectItem.Alias;
            Assert.IsNotNull(alias);
            Assert.AreEqual("Author", alias.ID);
            Assert.AreEqual("Originator", TestUtil.Stringify(selectItem.Item));

            parser = Factory.CreateParser("x = 1 + 2");
            selectItem = parser.selectItem();
            INode core = selectItem.Item;
            Assert.IsInstanceOfType(typeof(Expression), core);
            Assert.AreEqual("1 + 2", TestUtil.Stringify(core));

            parser = Factory.CreateParser("x = y + z");
            selectItem = parser.selectItem();
            Assert.IsNotNull(selectItem);
            alias = selectItem.Alias;
            Assert.IsNotNull(alias);
            Assert.AreEqual("x", alias.ID);
            core = selectItem.Item;
            Assert.IsInstanceOfType(typeof(Expression), core);
            Assert.AreEqual("y + z", TestUtil.Stringify(core));

            parser = Factory.CreateParser("address.*");
            selectItem = parser.selectItem();
            core = selectItem.Item;
            Assert.IsInstanceOfType(typeof(TableWildcard), core);
            Assert.AreEqual("address.*", TestUtil.Stringify(core));

            parser = Factory.CreateParser("1 + 2 * 3");
            selectItem = parser.selectItem();
            Assert.IsNotNull(selectItem);
            Assert.IsNull(selectItem.Alias);
            core = selectItem.Item;
            Assert.IsInstanceOfType(typeof(Expression), core);
            Assert.AreEqual("1 + (2 * 3)", TestUtil.Stringify(core));
        }

        [Test]
        public void TestPredicate()
        {
            MacroScopeParser parser = Factory.CreateParser("a >= b");
            Expression expression = parser.predicate() as Expression;
            Assert.IsNotNull(expression);
            Assert.AreEqual("a", TestUtil.Stringify(expression.Left));
            Assert.AreSame(ExpressionOperator.GreaterOrEqual,
                expression.Operator);
            Assert.AreEqual("b", TestUtil.Stringify(expression.Right));

            parser = Factory.CreateParser("c is null");
            expression = parser.predicate() as Expression;
            Assert.IsNotNull(expression);
            Assert.AreEqual("c", TestUtil.Stringify(expression.Left));
            Assert.AreSame(ExpressionOperator.IsNull,
                expression.Operator);
            Assert.IsNull(expression.Right);

            CheckPredicate("c IS NOT NULL");

            parser = Factory.CreateParser("d like 'Smith%'");
            expression = parser.predicate() as Expression;
            Assert.IsNotNull(expression);
            Assert.AreEqual("d", TestUtil.Stringify(expression.Left));
            Assert.AreSame(ExpressionOperator.Like,
                expression.Operator);

            PatternExpression patternExpression = expression.Right as PatternExpression;
            Assert.IsNotNull(patternExpression);
            Assert.AreEqual("'Smith%'", TestUtil.Stringify(patternExpression.Expression));
            Assert.IsNull(patternExpression.Escape);

            parser = Factory.CreateParser("comment LIKE '%30!%%' ESCAPE '!'");
            expression = parser.predicate() as Expression;
            Assert.IsNotNull(expression);

            patternExpression = expression.Right as PatternExpression;
            Assert.IsNotNull(patternExpression);
            Assert.AreEqual("'%30!%%'", TestUtil.Stringify(patternExpression.Expression));
            Assert.AreEqual("'!'", TestUtil.Stringify(patternExpression.Escape));

            parser = Factory.CreateParser("e between 1 and 10");
            expression = parser.predicate() as Expression;
            Assert.IsNotNull(expression);
            Assert.AreSame(ExpressionOperator.Between, expression.Operator);
            Assert.AreEqual("e BETWEEN 1 AND 10", TestUtil.Stringify(expression));

            parser = Factory.CreateParser("f in(+2, +3, +5, +7)");
            expression = parser.predicate() as Expression;
            Assert.IsNotNull(expression);
            Assert.AreEqual("f IN (2, 3, 5, 7)", TestUtil.Stringify(expression));

            string idempotent = "g1 NOT IN (SELECT name\r\nFROM week)";
            parser = Factory.CreateParser(idempotent);
            expression = parser.predicate() as Expression;
            Assert.IsNotNull(expression);
            Assert.AreEqual(idempotent, TestUtil.Stringify(expression));

            CheckPredicate("EXISTS (SELECT *\r\nFROM warehouse)");
        }

        void CheckPredicate(string idempotent)
        {
            CheckPredicate(idempotent, idempotent);
        }

        void CheckPredicate(string from, string to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            MacroScopeParser parser = Factory.CreateParser(from);
            IExpression expression = parser.predicate();
            Assert.IsNotNull(expression);
            Assert.AreEqual(to, TestUtil.Stringify(expression));
        }

        [Test]
        public void TestSubSearchCondition()
        {
            CheckSubSearchCondition("1 = 1");
            CheckSubSearchCondition("(1 = 1)", "1 = 1");
        }

        void CheckSubSearchCondition(string idempotent)
        {
            CheckSubSearchCondition(idempotent, idempotent);
        }

        void CheckSubSearchCondition(string from, string to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            MacroScopeParser parser = Factory.CreateParser(from);
            IExpression expression = parser.subSearchCondition();
            Assert.IsNotNull(expression);
            Assert.AreEqual(to, TestUtil.Stringify(expression));
        }

        [Test]
        public void TestSearchCondition()
        {
            MacroScopeParser parser = Factory.CreateParser("a != b");
            Expression expression = parser.searchCondition() as Expression;
            Assert.IsNotNull(expression);
            Assert.AreEqual("a <> b", TestUtil.Stringify(expression));

            parser = Factory.CreateParser("a + b > c");
            expression = parser.searchCondition() as Expression;
            Assert.IsNotNull(expression);
            Assert.AreEqual("(a + b) > c", TestUtil.Stringify(expression));

            parser = Factory.CreateParser("m != all (select n from x)");
            PredicateExpression predicateExpression = parser.searchCondition()
                as PredicateExpression;
            Assert.IsNotNull(predicateExpression);
            Assert.AreEqual("m <> ALL ( SELECT n\r\nFROM x )",
                TestUtil.Stringify(predicateExpression));

            parser = Factory.CreateParser("c is not null");
            expression = parser.searchCondition() as Expression;
            Assert.IsNotNull(expression);
            Assert.AreEqual("c IS NOT NULL", TestUtil.Stringify(expression));

            parser = Factory.CreateParser("1<>1 and 1<>1 or 1=1");
            expression = parser.searchCondition() as Expression;
            Assert.IsNotNull(expression);
            Assert.AreEqual("((1 <> 1) AND (1 <> 1)) OR (1 = 1)",
                TestUtil.Stringify(expression));

            parser = Factory.CreateParser("1 = 1 or 1 <> 1 and 1 <> 1");
            expression = parser.searchCondition() as Expression;
            Assert.IsNotNull(expression);
            Assert.AreEqual("(1 = 1) OR ((1 <> 1) AND (1 <> 1))",
                TestUtil.Stringify(expression));

            CheckSearchCondition("(1 = 1)", "1 = 1");

            CheckSearchCondition("NULL IS NULL");

            StringBuilder expected = new StringBuilder();
            expected.Append("((address.building_id = ");
            expected.Append("building.building_id) ");
            expected.Append("AND (building.settlement_id = settlement.settlement_id)) ");
            expected.Append("AND (settlement.village_id = village.village_id)");
            CheckSearchCondition(expected.ToString());

            CheckSearchCondition("updated >= 1");
            CheckSearchCondition("updated >= @threshold");
            CheckSearchCondition("updated >= :threshold");
            CheckSearchCondition("updated >= DATE()");
        }

        void CheckSearchCondition(string idempotent)
        {
            CheckSearchCondition(idempotent, idempotent);
        }

        void CheckSearchCondition(string from, string to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            MacroScopeParser parser = Factory.CreateParser(from);
            IExpression expression = parser.searchCondition();
            Assert.IsNotNull(expression);
            Assert.AreEqual(to, TestUtil.Stringify(expression));
        }

        [Test]
        public void TestFunction()
        {
            CheckFunction("LEFT(street, 10)");
            CheckFunction("RIGHT([text], 20)");
            CheckFunction("count(*)");
            CheckFunction("count(distinct predicate)",
                "count(DISTINCT predicate)");
            CheckFunction("sum(all price)", "sum(price)");
        }

        void CheckFunction(string idempotent)
        {
            CheckFunction(idempotent, idempotent);
        }

        void CheckFunction(string from, string to)
        {
            if (from == null)
            {
                throw new ArgumentNullException("from");
            }

            if (to == null)
            {
                throw new ArgumentNullException("to");
            }

            MacroScopeParser parser = Factory.CreateParser(from);
            IExpression functionCall = parser.function();
            Assert.IsNotNull(functionCall);

            Assert.AreEqual(to, TestUtil.Stringify(functionCall));
        }

        [Test]
        public void TestSelectWhere()
        {
            CheckSelect("SELECT * FROM INVENTORY WHERE DOWNLOADED IS NULL",
                "SELECT *\r\nFROM INVENTORY\r\nWHERE DOWNLOADED IS NULL");

            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT *\r\nFROM INVENTORY\r\n");
            expected.Append("WHERE (UPDATED_DATE = CREATED_DATE) ");
            expected.Append("AND ((DOWNLOADED <> '1') OR (DOWNLOADED IS NULL))\r\n");
            expected.Append("ORDER BY DELETED DESC, UPDATED_DATE");

            CheckSelect(@"SELECT * FROM INVENTORY
WHERE ((UPDATED_DATE=CREATED_DATE) AND (DOWNLOADED <> '1' OR DOWNLOADED IS NULL))
ORDER BY DELETED DESC, UPDATED_DATE",
                expected.ToString());
        }

        [Test]
        public void TestSelectGroupBy()
        {
            CheckSelect("select distinct dep_id from departments group by dep_id",
                "SELECT DISTINCT dep_id\r\nFROM departments\r\nGROUP BY dep_id");

            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT dep_id, max(salary)\r\n");
            expected.Append("FROM staff\r\nGROUP BY ALL dep_id\r\n");
            expected.Append("ORDER BY max(salary) DESC");
            CheckSelect(@"SELECT dep_id, max(salary) FROM staff GROUP BY ALL dep_id
ORDER BY max(salary) DESC", expected.ToString());

            expected = new StringBuilder();
            expected.Append("SELECT country_id, COUNT(*) AS c\r\n");
            expected.Append("FROM t\r\n");
            expected.Append("GROUP BY country_id\r\nHAVING c > 1\r\n");
            expected.Append("ORDER BY country_id");
            CheckSelect(@"SELECT country_id, COUNT(*) as c
FROM t
GROUP BY country_id
HAVING c > 1
ORDER BY country_id", expected.ToString());
        }

        [Test]
        public void TestSelectOrderBy()
        {
            CheckSelect("select * from area order by area_id ASC",
                "SELECT *\r\nFROM area\r\nORDER BY area_id");

            StringBuilder expected = new StringBuilder();
            expected.Append("SELECT area.area_id, province.province_id, ");
            expected.Append("district.district_id, city.city_id\r\n");
            expected.Append("FROM area ");
            expected.Append("INNER JOIN province ON area.area_id = province.area_id ");
            expected.Append("INNER JOIN district ON province.province_id = district.province_id ");
            expected.Append("INNER JOIN city ON district.city_id = city.city_id\r\n");
            expected.Append("ORDER BY area.area_id, province.province_id, ");
            expected.Append("district.district_id, city.city_id");

            CheckSelect(@"select area.area_id, province.province_id, district.district_id, city.city_id
from area
join province on area.area_id=province.area_id
join district on province.province_id=district.province_id
join city on district.city_id=city.city_id
order by area.area_id,province.province_id,district.district_id,city.city_id",
                expected.ToString());

            SelectStatement statement = Factory.CreateStatement(
                "select area.* from area") as SelectStatement;
            Assert.IsNotNull(statement);

            QueryExpression queryExpression = statement.SingleQueryExpression;
            Assert.IsNotNull(queryExpression);
            Assert.IsNull(queryExpression.OrderBy);

            MacroScopeParser parser = Factory.CreateParser("area.area_id");
            IExpression expression = parser.expression();
            Assert.IsNotNull(expression);

            OrderExpression orderExpression = new OrderExpression(expression);
            queryExpression.OrderBy = orderExpression;

            string sql = TestUtil.Stringify(statement);
            Assert.AreEqual("SELECT area.*\r\nFROM area\r\nORDER BY area.area_id",
                sql);

            CheckSelect("SELECT * FROM fact ORDER BY subject, predicate desc, [object]",
                "SELECT *\r\nFROM fact\r\nORDER BY subject, predicate DESC, [object]");
            CheckSelect(@"SELECT *
FROM fact
ORDER BY
subject ASC, predicate DESC, [object] ASC",
                "SELECT *\r\nFROM fact\r\nORDER BY subject, predicate DESC, [object]");
        }

        [Test]
        public void TestSelectUnion()
        {
            CheckSelect("select * from area union select * from province",
                "SELECT *\r\nFROM area\r\nUNION\r\nSELECT *\r\nFROM province");
        }

        [Test]
        public void TestCaseInsensitive()
        {
            CheckSelect("SELECT 1", "SELECT 1");
            CheckSelect("Select 1.5", "SELECT 1.5");
            CheckSelect("select 1E4", "SELECT 10000");
            CheckSelect("select 3E-2", "SELECT 0.03");
            CheckSelect("sElEct 1 + 2", "SELECT 1 + 2");
            CheckSelect("select 42 AS ANSWER", "SELECT 42 AS ANSWER");
        }

        [Test]
        public void TestParseError()
        {
            CheckParseError("");
            CheckParseError("lsfng lsgnek e");
            CheckParseError("SELECT a>b");
            CheckParseError("SELECT '''");
            CheckParseError("SELECT 'admin'--'");
            CheckParseError("SELECT 'kùò'");
            CheckParseError("SELECT * FROM s CROSS JOIN t ON a=b");

            CheckParseError(@"SELECT * FROM s
CROSS JOIN (SELECT c FROM t)");

            CheckParseError("INSERT INTO t(a)");
        }

        void CheckParseError(string incorrect)
        {
            if (incorrect == null)
            {
                throw new ArgumentNullException("incorrect");
            }

            try
            {
                Factory.CreateStatement(incorrect);
                Assert.Fail();
            }
            catch (RecognitionException exception)
            {
                Assert.IsNotNull(exception);
            }
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

            SelectStatement selectStatement = statement as SelectStatement;
            Assert.IsNotNull(selectStatement);

            Assert.AreEqual(to, TestUtil.Stringify(selectStatement));
        }

        void CheckInsert(string idempotent)
        {
            CheckInsert(idempotent, idempotent);
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

            InsertStatement insertStatement = statement as InsertStatement;
            Assert.IsNotNull(insertStatement);

            Assert.AreEqual(to, TestUtil.Stringify(insertStatement));
        }

        void CheckUpdate(string idempotent)
        {
            CheckUpdate(idempotent, idempotent);
        }

        void CheckUpdate(string from, string to)
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

            UpdateStatement updateStatement = statement as UpdateStatement;
            Assert.IsNotNull(updateStatement);

            Assert.AreEqual(to, TestUtil.Stringify(updateStatement));
        }

        void CheckDelete(string idempotent)
        {
            CheckDelete(idempotent, idempotent);
        }

        void CheckDelete(string from, string to)
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

            DeleteStatement deleteStatement = statement as DeleteStatement;
            Assert.IsNotNull(deleteStatement);

            Assert.AreEqual(to, TestUtil.Stringify(deleteStatement));
        }
    }
}
