using System;
using System.Collections;
using System.Configuration;
using MacroScope;

namespace TestGlaze
{
    public static class TestUtil
    {
        public static string[] Providers
        {
            get
            {
                ArrayList p = new ArrayList();
                foreach (string key in ConfigurationManager.AppSettings)
                {
                    if ((key != null) &&
                        (key.Equals(Factory.MSQLProvider) || key.Equals(Factory.OleDbProvider) ||
                            key.Equals(Factory.OracleProvider)))
                    {
                        p.Add(key);
                    }
                }

                return (string[])p.ToArray(typeof(string));
            }
        }
    }
}
