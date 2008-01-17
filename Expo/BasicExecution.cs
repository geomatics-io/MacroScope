using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using Glaze;

namespace Seminar
{
    public class BasicExecution
    {
        void Test()
        {
            AppSettingsReader configuration = new AppSettingsReader();
            string databaseProvider = configuration.GetValue(
                "DatabaseProvider", typeof(string)) as string;
            string connectionString = configuration.GetValue(
                "ConnectionString", typeof(string)) as string;

            GlazeFactory provider = new GlazeFactory(databaseProvider);
            DbConnection connection = provider.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            try
            {
                DbCommand command = connection.CreateCommand();
                command.CommandText = "SELECT count(*) FROM table_name";
                object total = command.ExecuteScalar();
                Console.WriteLine("{0}", total);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
