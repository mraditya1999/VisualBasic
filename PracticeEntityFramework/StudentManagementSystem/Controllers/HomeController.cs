using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentManagement _context = new StudentManagement();

        [HttpGet]
        public ActionResult Index()
        {
            var students = _context.GetAllStudentDetails();
            return View(students);
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.AddStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        [HttpGet]
        public ActionResult UpdateStudent(int studentId)
        {
            var student = _context.GetAllStudentDetails().FirstOrDefault(x => x.studentId == studentId);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        [HttpPost]
        public ActionResult UpdateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        [HttpGet]
        public ActionResult DeleteStudent(int studentId)
        {
            _context.DeleteStudent(studentId);
            return RedirectToAction("Index");
        }

    }
}