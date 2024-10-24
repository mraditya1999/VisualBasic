using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppData.Models
{
    public class StudentManagementDb:IStudent
    {
        private readonly string ConnectionString = @"Data Source =.\sqlexpress ; Initial Catalog = dac_db;Integrated Security=True;";

        //public StudentManagementDb() {
             
        //}

        public IEnumerable<Student> GetStudents()
        {
           Cdal dal = new Cdal(ConnectionString); 
            return dal.GetStudents();
        }
    }
    public class Cdal
    {
        private readonly string ConnectionString;
        SqlConnection cnn;
        SqlCommand cmd;
        public Cdal(string ConnectionString)
        {
            cnn = new SqlConnection(ConnectionString);
            cmd = new SqlCommand();
            cmd.Connection = cnn;
        }

        public IEnumerable<Student> GetStudents() 
        {
            List<Student> studentsList = new List<Student>();
            cmd.CommandText = "Select * from Students";
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                studentsList.Add(new Student { StudentId = reader.GetInt32(0), StudentName = reader.GetString(1), StudentCourse = reader.GetString(2) });

            }
            reader.Close();
            cnn.Close();
            return studentsList;
        }
    }
}