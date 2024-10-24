using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFakeRepository2.Models
{
    public interface IStudent
    {
        IEnumerable<Student> GetStudents();

        void AddStudent(Student student);

        void UpdateStudent(Student student);

        void DeleteStudent(int StudentId);
    }
}
