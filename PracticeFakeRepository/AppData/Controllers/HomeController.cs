using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppData.Controllers
{
    public class HomeController : Controller
    {
        IStudent Student;
        public HomeController(IStudent stu)
        {
            //Student = new StudentManagement();
            Student = stu;
        } 

        // GET: Home
        public ActionResult Index()
        {

            return View(Student.GetStudents());
        }


    }
}