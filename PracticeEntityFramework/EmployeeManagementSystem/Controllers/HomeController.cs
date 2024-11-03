using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeManagement _context = new EmployeeManagement();

        [HttpGet]
        public ActionResult Index()
        {
            var employees = _context.GetAllEmployeesDetails();
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
            if (ModelState.IsValid)
            {
                _context.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        [HttpGet]
        public ActionResult UpdateEmployee(int employeeId)
        {
            var employee = _context.GetAllEmployeesDetails().FirstOrDefault(e => e.employeeId == employeeId);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        [HttpGet]
        public ActionResult DeleteEmployee(int employeeId)
        {
            _context.DeleteEmployee(employeeId);
            return RedirectToAction("Index");
        }
    }
}