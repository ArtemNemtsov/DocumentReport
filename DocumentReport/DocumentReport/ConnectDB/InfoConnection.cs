namespace DocumentReport
{
    using System.Configuration;
    using System.Data.Common;

    public static class InfoConnection
    {
        private static readonly string OracleProvider = ConfigurationManager.ConnectionStrings["connOracleSource"].ProviderName;
        private static readonly string OracleKey = "System.Data.OracleClient";

        public static string ConnectionString { get; private set; }

        public static void BuildConnectionString()
        {
            DbConnectionStringBuilder connectionStringBuilder = new DbConnectionStringBuilder
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["connOracleSource"].ConnectionString,
            };

            ConnectionString = connectionStringBuilder.ConnectionString;
        }

        private static void SaveConnection(string connection)
        {
            ConnectionString = connection;
        }
    }
}
