using System;
using NUnit.Framework;
using MacroScope;

namespace TestMacroScope
{
    [TestFixture]
    public class MAccessDateTimeTest
    {
        [Test]
        public void TestDateTime()
        {
            LiteralDateTime ldt = new LiteralDateTime("#2007-07-11 16:30:00#");
            DateTime dt = ldt.DateTime;
            Assert.AreEqual(2007, dt.Year);
            Assert.AreEqual(7, dt.Month);
            Assert.AreEqual(11, dt.Day);
            Assert.AreEqual(16, dt.Hour);
            Assert.AreEqual(30, dt.Minute);
            Assert.AreEqual(0, dt.Second);

            ldt = new LiteralDateTime("2007-07-11T16:30:00");
            dt = ldt.DateTime;
            Assert.AreEqual(2007, dt.Year);
            Assert.AreEqual(7, dt.Month);
            Assert.AreEqual(11, dt.Day);
            Assert.AreEqual(16, dt.Hour);
            Assert.AreEqual(30, dt.Minute);
            Assert.AreEqual(0, dt.Second);
        }

        [Test]
        public void TestMAccessLiteral()
        {
            LiteralDateTime ldt = new LiteralDateTime("#2007-07-11 16:30:00#");
            Assert.AreEqual("#2007-07-11 16:30:00#", ldt.MAccessLiteral);

            ldt = new LiteralDateTime("2007-07-11T16:30:00");
            Assert.AreEqual("#2007-07-11 16:30:00#", ldt.MAccessLiteral);
        }

        [Test]
        public void TestIso8601Literal()
        {
            LiteralDateTime ldt = new LiteralDateTime("#2007-07-11 16:30:00#");
            Assert.AreEqual("2007-07-11T16:30:00", ldt.Iso8601Literal);

            ldt = new LiteralDateTime("2007-07-11 16:30:00");
            Assert.AreEqual("2007-07-11T16:30:00", ldt.Iso8601Literal);
        }
    }
}
