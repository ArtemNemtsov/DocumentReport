namespace DocumentReport
{
    using System.Configuration;
    using System.Data.Common;

    public static class InfoConnection
    {
        public static string ConnectionString { get; private set; }

        public static void BuildConnectionString()
        {
            DbConnectionStringBuilder connectionStringBuilder = new DbConnectionStringBuilder
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["PostgreSource"].ConnectionString,
            };

            ConnectionString = connectionStringBuilder.ConnectionString;
        }

        private static void SaveConnection(string connection)
        {
            ConnectionString = connection;
        }
    }
}
