using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem
{
    public class EmployeeManagement
    {
        public List<Employee> GetAllEmployeesDetails()
        {
            using (var entities = new EmployeeManagementSystemEntities())
            {
                return entities.Employees.ToList();
            }
        }

        public void AddEmployee(Employee emp)
        {
            using (var entities = new EmployeeManagementSystemEntities())
            {
                entities.Employees.Add(emp);
                entities.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee employeeToBeUpdated)
        {
            using (var entities = new EmployeeManagementSystemEntities())
            {
                var existingEmployee = entities.Employees.FirstOrDefault(emp => emp.employeeId == employeeToBeUpdated.employeeId);
                if (existingEmployee != null)
                {
                    existingEmployee.employeeName = employeeToBeUpdated.employeeName;
                    existingEmployee.employeeDesignation = employeeToBeUpdated.employeeDesignation;
                    existingEmployee.employeeSalary = employeeToBeUpdated.employeeSalary;
                    entities.SaveChanges();
                }
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            using (var entities = new EmployeeManagementSystemEntities())
            {
                var employee = entities.Employees.FirstOrDefault(emp => emp.employeeId == employeeId);
                if (employee != null)
                {
                    entities.Employees.Remove(employee);
                    entities.SaveChanges();
                }
            }
        }
    }
}