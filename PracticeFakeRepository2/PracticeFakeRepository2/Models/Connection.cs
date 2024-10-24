using System;
using System.Data.SqlClient;

namespace PracticeFakeRepository2.Models
{
    public class Connection
    {
        public string ConnectionString { get; }
        public SqlConnection con { get; }
        public SqlCommand cmd { get; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
            con = new SqlConnection(connectionString);
            cmd = new SqlCommand { Connection = con };
        }
    }
}
