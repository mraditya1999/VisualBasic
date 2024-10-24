using PracticeFakeRepository2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeFakeRepository2.Controllers
{
    public class HomeController : Controller
    {
        IStudent student;

        public HomeController()
        {
            //student = new Student();
            student = new StudentDB();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(student.GetStudents());
        }

        [HttpPost]
        public ActionResult AddStudent(int studentId, string studentName, string studentCourse)
        {
            var newStudent = new Student
            {
                StudentId = studentId,
                StudentName = studentName,
                StudentCourse = studentCourse
            };

            student.AddStudent(newStudent);
            return RedirectToAction("Index");
        }



        [HttpPost]
        public ActionResult UpdateStudent(int studentId, string studentName, string studentCourse)
        {
            var updatedStudent = new Student
            {
                StudentId = studentId,
                StudentName = studentName,
                StudentCourse = studentCourse
            };

            student.UpdateStudent(updatedStudent);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteStudent(int studentId)
        {
            student.DeleteStudent(studentId);
            return RedirectToAction("Index");

        }
    }
}