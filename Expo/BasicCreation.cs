using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using Glaze;

namespace Seminar
{
    public class BasicCreation
    {
        void Test()
        {
            AppSettingsReader configuration = new AppSettingsReader();
            string databaseProvider = configuration.GetValue(
                "DatabaseProvider", typeof(string)) as string;

            GlazeFactory provider = new GlazeFactory(databaseProvider);
            DbConnection connection = provider.CreateConnection();
            DbCommand command = connection.CreateCommand();
        }
    }
}
