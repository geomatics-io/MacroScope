using System;
using NUnit.Framework;
using MacroScope;

namespace TestMacroScope
{
    [TestFixture]
    public class ParamPickerTest
    {
        [Test]
        public void TestGetAllParams()
        {
            ParamPicker paramPicker = new ParamPicker();
            Assert.IsNull(paramPicker.GetAllParams());

            IStatement statement = Factory.CreateStatement(
                "INSERT t(a, b, c) VALUES(@a, @b, @c)");
            statement.Traverse(paramPicker);

            string[] actual = paramPicker.GetAllParams();
            string[] expected = { "@a", "@b", "@c" };
            Assert.AreEqual(expected, actual);

            paramPicker = new ParamPicker();
            statement = Factory.CreateStatement(
                "INSERT t(a, b, c) VALUES(1, 2, 3)");
            actual = paramPicker.GetAllParams();
            Assert.IsNull(actual);
        }

        [Test]
        public void GetUniqueParams()
        {
            ParamPicker paramPicker = new ParamPicker();
            Assert.IsNull(paramPicker.GetUniqueParams());

            IStatement statement = Factory.CreateStatement(
                "update t set id=:id, a=:a, b=:b where id=@ID");
            statement.Traverse(paramPicker);

            string[] actual = paramPicker.GetUniqueParams();
            string[] expected = { ":a", ":b", ":id" };
            Assert.AreEqual(expected, actual);
        }
    }
}
