using System;
using System.Data;
using System.Data.Common;
using NUnit.Framework;
using Glaze;

namespace TestGlaze
{
    [TestFixture]
    public class GlazeConnectionTest
    {
        [Test]
        public void TestState()
        {
            string[] providers = TestUtil.Providers;

            if (providers.Length == 0)
            {
                Console.WriteLine("No database tested. Consider creating TestGlaze.exe.config and configuring some providers.");
            }

            for (int i = 0; i < providers.Length; ++i)
            {
                GlazeFactory glazeFactory = new GlazeFactory(providers[i]);
                DbConnection connection = glazeFactory.CreateConnection();
                Assert.AreEqual(ConnectionState.Closed, connection.State);
            }
        }
    }
}
