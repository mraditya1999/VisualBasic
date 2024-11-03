using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using WebApplication.Models.Abstract;

namespace WebApplication.dataAccessLayer
{
    public class StudentDal
    {

        public IEnumerable<Student> GetStudentDetails()
        {
            Connection obj = new Connection();
            List<Student> studentsList = new List<Student>();
            obj.cmd.CommandText = "Select * from Student";
            obj.con.Open();
            SqlDataReader reader = obj.cmd.ExecuteReader();
            while (reader.Read())
            {
                studentsList.Add(new Student { StudentId = reader.GetInt32(0), StudentName = reader.GetString(1), StudentCourse = reader.GetString(2) });
            }
            reader.Close();
            obj.con.Close();
            return studentsList;
        }

        public void AddStudent(Student student)
        {
            Connection obj = new Connection();
            obj.cmd.CommandText = $"Insert into Student (studentId, studentName, studentCourse) values('{student.StudentId}','{student.StudentName}','{student.StudentCourse}' )";
            obj.con.Open();
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }

        public void UpdateStudent(Student student)
        {
            Connection obj = new Connection();
            obj.cmd.CommandText = $"UPDATE Student SET studentName = '{student.StudentName}', studentCourse = '{student.StudentCourse}' WHERE studentId = '{student.StudentId}'";
            obj.con.Open();
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }

        public void DeleteStudent(int studentId)
        {
            Connection obj = new Connection();
            obj.cmd.CommandText = $"DELETE FROM Student WHERE studentId = '{studentId}'";
            obj.con.Open();
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }


    }
}