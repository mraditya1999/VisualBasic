using StudentManagementSystem.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.DataAccessLayer
{
    public class StudentDAL
    {
        public IEnumerable<Student> GetAllStudentDetails()
        {
            Connection obj = new Connection();
            List<Student> studentList = new List<Student>();
            obj.cmd.CommandText = "select * from Student";
            obj.con.Open();
            SqlDataReader reader = obj.cmd.ExecuteReader();
            while (reader.Read())
            {
                studentList.Add(new Student { StudentId = reader.GetInt32(0), StudentName = reader.GetString(1), StudentCourse = reader.GetString(2) });
            }
            reader.Close();
            obj.con.Close();
            return studentList;
        }

        public void AddStudent(Student student)
        {
            Connection obj = new Connection();
            obj.cmd.CommandText = $"INSERT INTO Student (studentId, studentName, studentCourse) VALUES ({student.StudentId}, '{student.StudentName}', '{student.StudentCourse}')";
            obj.con.Open();
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }

        public void UpdateStudent(Student student)
        {
            Connection obj = new Connection();
            obj.cmd.CommandText = $"UPDATE Student SET studentName='{student.StudentName}', studentCourse='{student.StudentCourse}' WHERE studentId='{student.StudentId}'";
            obj.con.Open();
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }


        public void DeleteStudent(int studentId)
        {
            Connection obj = new Connection();
            obj.cmd.CommandText = $"DELETE FROM Student WHERE studentId='{studentId}'";
            obj.con.Open();
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }
    }
}