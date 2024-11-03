using EmployeeManagementSystem.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeManagementSystem.DataAccessLayer
{
    public class EmployeeDAL
    {
        public void AddEmployee(Employee employee)
        {
            Connection obj = new Connection();
            obj.con.Open();
            obj.cmd.CommandText = $"INSERT INTO Employee (employeeId,employeeName,employeeDesignation,employeeSalary) values ('{employee.EmployeeId}','{employee.EmployeeName}','{employee.EmployeeDesignation}','{employee.EmployeeSalary}')";
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();

        }

        public void DeleteEmployee(int employeeId)
        {
            Connection obj = new Connection();
            obj.con.Open();
            obj.cmd.CommandText = $"Delete FROM Employee WHERE employeeId = {employeeId}";
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }

        public IEnumerable<Employee> GetAllEmployeesDetails()
        {
            Connection obj = new Connection();
            List<Employee> employeesList = new List<Employee>();
            obj.cmd.CommandText = "SELECT * FROM Employee";
            obj.con.Open();
            SqlDataReader reader = obj.cmd.ExecuteReader();


            while (reader.Read())
            {
                employeesList.Add(new Employee
                {
                    EmployeeId = reader.GetInt32(0),
                    EmployeeName = reader.GetString(1),
                    EmployeeDesignation = reader.GetString(2),
                    //EmployeeSalary = reader.GetFloat(3)
                });
            }
            reader.Close();
            obj.con.Close();
            return employeesList;
        }

        public void UpdateEmployee(Employee employee)
        {
            Connection obj = new Connection();
            obj.con.Open();
            obj.cmd.CommandText = $"UPDATE Employee SET employeeName = '{employee.EmployeeName}', employeeDesignation = '{employee.EmployeeDesignation}', employeeSalary = '{employee.EmployeeSalary}' Where employeeId = '{employee.EmployeeId}'";
            obj.cmd.ExecuteNonQuery();
            obj.con.Close();
        }
    }
}