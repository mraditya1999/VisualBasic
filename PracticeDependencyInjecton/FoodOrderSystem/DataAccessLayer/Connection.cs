using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FoodOrderSystem.DataAccessLayer
{
    public class Connection
    {
        private readonly string connectionString = @"Data Source = .\sqlexpress; Initial Catalog = FoodOrderSystem ; Integrated Security = True";
        public SqlConnection con;
        public SqlCommand cmd;

        public Connection()
        {
            con = new SqlConnection(connectionString);
            cmd = con.CreateCommand();
        }
    }
}