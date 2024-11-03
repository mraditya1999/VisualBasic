using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Models.Abstract
{
    public interface IStudent
    {
        IEnumerable<Student> GetStudentDetails();

        void AddStudent(Student student);
        void UpdateStudent(Student student);

        void DeleteStudent(int studentId);
    }
}
