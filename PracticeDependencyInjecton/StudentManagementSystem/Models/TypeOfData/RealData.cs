using StudentManagementSystem.DataAccessLayer;
using StudentManagementSystem.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models.TypeOfData
{
    public class RealData : IStudent
    {
        public void AddStudent(Student student)
        {
            StudentDAL dal = new StudentDAL();
            dal.AddStudent(student);
        }

        public void DeleteStudent(int studentId)
        {
            StudentDAL dal = new StudentDAL();
            dal.DeleteStudent(studentId);
        }

        public IEnumerable<Student> GetAllStudentDetails()
        {
            StudentDAL dal = new StudentDAL();
            var studentsList = (from stu in dal.GetAllStudentDetails() select stu).ToList();
            return studentsList;
        }

        public void UpdateStudent(Student student)
        {
            StudentDAL dal = new StudentDAL();
            dal.UpdateStudent(student);
        }
    }
}