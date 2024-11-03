using EmployeeManagementSystem.Models.Abstract;
using EmployeeManagementSystem.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployee _employee;
        public HomeController(IEmployee emp)
        {
            _employee = emp;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var employees = _employee.GetAllEmployeesDetails();
            return View(employees);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View(new Employee());
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            _employee.AddEmployee(employee);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateEmployee(int employeeId)
        {
            var employee = (from emp in _employee.GetAllEmployeesDetails() select emp).FirstOrDefault(e => e.EmployeeId == employeeId);
            return View(employee);
        }


        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee)
        {
            _employee.UpdateEmployee(employee);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteEmployee(int employeeId)
        {
            _employee.DeleteEmployee(employeeId);
            return RedirectToAction("Index");
        }
    }
}