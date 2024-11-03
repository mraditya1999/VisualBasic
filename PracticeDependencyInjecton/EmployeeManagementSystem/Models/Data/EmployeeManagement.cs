using EmployeeManagementSystem.DataAccessLayer;
using EmployeeManagementSystem.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Models.Data
{
    public class EmployeeManagement : IEmployee
    {
        public void AddEmployee(Employee employee)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            employeeDAL.AddEmployee(employee);
        }

        public void DeleteEmployee(int employeeId)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            employeeDAL.DeleteEmployee(employeeId);
        }

        public IEnumerable<Employee> GetAllEmployeesDetails()
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            var employeesList = (from emp in employeeDAL.GetAllEmployeesDetails() select emp).ToList();
            return employeesList;
        }

        public void UpdateEmployee(Employee employee)
        {
            EmployeeDAL employeeDAL = new EmployeeDAL();
            employeeDAL.UpdateEmployee(employee);
        }
    }
}