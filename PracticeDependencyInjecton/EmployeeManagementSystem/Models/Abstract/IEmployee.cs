using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models.Abstract
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetAllEmployeesDetails();
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);

    }
}
