using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.dataAccessLayer;
using WebApplication.Models.Abstract;

namespace WebApplication.Models.RealData
{
    public class RealData : IStudent
    {
        public void AddStudent(Student student)
        {
            StudentDal studentDal = new StudentDal();
            studentDal.AddStudent(student);
        }

        public void DeleteStudent(int studentId)
        {
            StudentDal studentDal = new StudentDal();
            studentDal.DeleteStudent(studentId);
        }

        public IEnumerable<Student> GetStudentDetails()
        {
            StudentDal dal = new StudentDal();
            var studentsList = (from stu in dal.GetStudentDetails() select stu).ToList();
            return studentsList;
        }

        public void UpdateStudent(Student student)
        {
            StudentDal studentDal = new StudentDal();
            studentDal.UpdateStudent(student);
        }
    }
}