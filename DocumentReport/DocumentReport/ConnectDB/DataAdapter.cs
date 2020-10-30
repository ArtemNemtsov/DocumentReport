namespace DocumentReport
{
    using System;
    using System.Data;
    using System.Data.OracleClient;

    public static class DataAdapter
    {
        public static DataTable SelectData(string query)
        {
            DataTable dt = new DataTable();
            using (OracleConnection connection = new OracleConnection(InfoConnection.ConnectionString))
            {
                connection.Open();
                OracleCommand cmd = new OracleCommand(query, connection);
                dt.Load(cmd.ExecuteReader());
                connection.Close();
            }
            return dt;
        }

        public static T GetValue<T>(string query)
        {
            object value = null;
            using (OracleConnection connection = new OracleConnection(InfoConnection.ConnectionString))
            {
                connection.Open();
                OracleCommand cmd = new OracleCommand(query, connection);
                value = cmd.ExecuteScalar();
                connection.Close();

                switch (Type.GetTypeCode(typeof(T)))
                {
                    case TypeCode.Int32:
                        value = Convert.ToInt32(value);
                        break;
                    case TypeCode.Boolean:
                        value = Convert.ToBoolean(value);
                        break;
                    case TypeCode.Decimal:
                        value = Convert.ToDecimal(value);
                        break;
                    case TypeCode.Double:
                        value = Convert.ToDouble(value);
                        break;
                    case TypeCode.String:
                        value = Convert.ToString(value);
                        break;
                    case TypeCode.DateTime:
                        value = Convert.ToDateTime(value);
                        break;
                    default:
                        value = null;
                        break;
                }
            }
            return (T)value;
        }

        public static object GetScalarValue(string query)
        {
            object value = null;
            using (OracleConnection connection = new OracleConnection(InfoConnection.ConnectionString))
            {
                connection.Open();
                OracleCommand cmd = new OracleCommand(query, connection);
                value = cmd.ExecuteScalar();
            }
            return value ?? string.Empty;
        }

        public static void ExecutetNonQuery(string query)
        {
            using (OracleConnection connection = new OracleConnection(InfoConnection.ConnectionString))
            {
                connection.Open();
                OracleCommand cmd = new OracleCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
