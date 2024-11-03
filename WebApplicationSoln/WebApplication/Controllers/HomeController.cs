using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models.Abstract;
using WebApplication.Models.RealData;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudent _student;

        public HomeController()
        {
            _student = new RealData();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_student.GetStudentDetails());
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            _student.AddStudent(student);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateStudent(int studentId)
        {
            var student = _student.GetStudentDetails().FirstOrDefault(stu => stu.StudentId == studentId);
            return View(student);
        }

        [HttpPost]
        public ActionResult UpdateStudent(Student student)
        {
            _student.UpdateStudent(student);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteStudent(int studentId)
        {
            _student.DeleteStudent(studentId);
            return RedirectToAction("Index");
        }
    }
}