using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication.dataAccessLayer
{
    public class Connection
    {
        public readonly string ConnectionString = @"Data Source = .\sqlexpress;Initial Catalog = StudentManagementSystem; Integrated Security = True";
        public SqlConnection con;
        public SqlCommand cmd;
        public Connection()
        {
            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
    }
}