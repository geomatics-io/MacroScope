using System;
using MacroScope;

namespace TestMacroScope
{
    public static class TestUtil
    {
        public static string Stringify(INode node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            Stringifier stringifier = new Stringifier();
            node.Traverse(stringifier);
            return stringifier.ToSql();
        }
    }
}
