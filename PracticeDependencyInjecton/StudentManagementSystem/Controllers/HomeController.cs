using StudentManagementSystem.Models.Abstract;
using StudentManagementSystem.Models.TypeOfData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudent student;

        public HomeController(IStudent stu)
        {
            this.student = stu;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(student.GetAllStudentDetails());
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult AddStudent(Student stu)
        {
            student.AddStudent(stu);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateStudent(int studentId)
        {
            var result = (from stu in student.GetAllStudentDetails() where stu.StudentId == studentId select stu).FirstOrDefault();
            return View(result);
        }

        [HttpPost]
        public ActionResult UpdateStudent(Student stu)
        {
            student.UpdateStudent(stu);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteStudent(int studentId)
        {
            student.DeleteStudent(studentId);
            return RedirectToAction("Index");
        }
    }
}