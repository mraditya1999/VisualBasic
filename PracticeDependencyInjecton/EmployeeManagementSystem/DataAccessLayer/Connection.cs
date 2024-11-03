using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.DataAccessLayer
{
    public class Connection
    {
        private readonly string ConnectionString = @"Data Source = .\sqlexpress ; Initial catalog = EmployeeManagementSystem  ;Integrated Security = True";
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