using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models.Abstract
{
    public class Student
    {
        public int StudentId { get; set; }
        public String StudentName { get; set; }
        public String StudentCourse { get; set; }
    }
}