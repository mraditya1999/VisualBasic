using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StudentManagementSystem.Models.Abstract
{
    public interface IStudent
    {
        IEnumerable<Student> GetAllStudentDetails();
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int studentId);


    }
}
