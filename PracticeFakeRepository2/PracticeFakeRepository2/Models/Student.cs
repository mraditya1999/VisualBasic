using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeFakeRepository2.Models
{
    public class Student : IStudent
    {
        public int StudentId { set; get; }

        public string StudentName { set; get; }

        public string StudentCourse { set; get; }


        public static List<Student> StudentsList;

        static Student()
        {
            StudentsList = new List<Student> {
        new Student { StudentId = 101, StudentName = "Aditya Yadav", StudentCourse = "DAC" },
        new Student { StudentId = 102, StudentName = "Nikhil Katoch", StudentCourse = "DAC" }
    };
        }

        public IEnumerable<Student> GetStudents()
        {
            return StudentsList;
        }

        public void AddStudent(Student student)
        {
            StudentsList.Add(student);
        }

        public void UpdateStudent(Student student)
        {
            var existingStudent = StudentsList.FirstOrDefault(s => s.StudentId == student.StudentId);
            if (existingStudent != null)
            {
                existingStudent.StudentName = student.StudentName;
                existingStudent.StudentCourse = student.StudentCourse;
            }
        }


        public void DeleteStudent(int StudentId)
        {
            var studentt = StudentsList.FirstOrDefault(s => s.StudentId == StudentId);
            if (studentt != null)
            {
                StudentsList.Remove(studentt);
            }
        }
    }
}