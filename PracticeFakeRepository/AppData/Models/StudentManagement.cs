using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppData.Models
{
    public class StudentManagement:IStudent
    {
         List<Student> StudentsList = new List<Student>();

        public StudentManagement() {
            StudentsList.Add(new Student { StudentId=101,StudentName="Aditya Yadav",StudentCourse="DAC" });
            StudentsList.Add(new Student { StudentId = 102, StudentName = "Nikhil katoch", StudentCourse = "DAC" });
        }

        public IEnumerable<Student> GetStudents()
        {
           return StudentsList;
        }
    }
}