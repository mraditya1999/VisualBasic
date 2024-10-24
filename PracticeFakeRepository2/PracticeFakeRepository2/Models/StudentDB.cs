using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PracticeFakeRepository2.Models
{
    public class StudentDB : IStudent
    {

        public int StudentId { set; get; }

        public string StudentName { set; get; }

        public string StudentCourse { set; get; }

        private static readonly string ConnectionString = @"Data Source=.\sqlexpress; Initial Catalog=dac_db; Integrated Security=True;";

        public IEnumerable<Student> GetStudents()
  {
      Connection obj = new Connection(ConnectionString);
      List<Student> studentsList = new List<Student>();
      obj.cmd.CommandText = "Select * from Students";
      obj.con.Open();
      SqlDataReader reader = obj.cmd.ExecuteReader();
      while (reader.Read())
      {
          studentsList.Add(new Student
          {
              StudentId = reader.GetInt32(0),
              StudentName = reader.GetString(1),
              StudentCourse = reader.GetString(2)
          });
      }
      reader.Close();
      obj.con.Close();
      return studentsList;
  }
  public void AddStudent(Student student)
  {
      Connection obj = new Connection(ConnectionString);
      obj.cmd.CommandText = $"INSERT INTO Students (StudentId, StudentName, StudentCourse) VALUES ({student.StudentId}, '{student.StudentName}', '{student.StudentCourse}')";
      obj.con.Open();
      obj.cmd.ExecuteNonQuery();
      obj.con.Close();
  }

  public void UpdateStudent(Student student)
  {
      Connection obj = new Connection(ConnectionString);
      obj.cmd.CommandText = $"UPDATE Students SET StudentName='{student.StudentName}', StudentCourse='{student.StudentCourse}' WHERE StudentId={student.StudentId}";
      obj.con.Open();
      obj.cmd.ExecuteNonQuery();
      obj.con.Close();
  }


  public void DeleteStudent(int studentId)
  {
      Connection obj = new Connection(ConnectionString);
      obj.cmd.CommandText = $"DELETE FROM Students WHERE StudentId={studentId}";
      obj.con.Open();
      obj.cmd.ExecuteNonQuery();
      obj.con.Close();
  }
    }
}