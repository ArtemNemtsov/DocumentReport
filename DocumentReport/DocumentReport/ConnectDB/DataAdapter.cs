namespace DocumentReport
{
    using Npgsql;
    using System;
    using System.Data;

    public static class DataAdapter
    {
        public static DataTable SelectData(string query)
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection connection = new NpgsqlConnection(InfoConnection.ConnectionString))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                dt.Load(cmd.ExecuteReader());
                connection.Close();
            }
            return dt;
        }

        public static T GetValue<T>(string query)
        {
            object value = null;
            using (NpgsqlConnection connection = new NpgsqlConnection(InfoConnection.ConnectionString))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
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
            using (NpgsqlConnection connection = new NpgsqlConnection(InfoConnection.ConnectionString))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                value = cmd.ExecuteScalar();
            }
            return value ?? string.Empty;
        }

        public static void ExecutetNonQuery(string query)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(InfoConnection.ConnectionString))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
