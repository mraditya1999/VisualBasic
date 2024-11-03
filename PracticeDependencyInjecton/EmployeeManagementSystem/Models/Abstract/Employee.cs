using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.Models.Abstract
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public String EmployeeName { get; set; }
        public String EmployeeDesignation { get; set; }
        public float EmployeeSalary { get; set; }
    }
}