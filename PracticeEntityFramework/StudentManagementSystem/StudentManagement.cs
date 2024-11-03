using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementSystem
{
    public class StudentManagement
    {
        public List<Student> GetAllStudentDetails()
        {
            using (var entities = new StudentManagementSystemEntities())
            {
                return entities.Students.ToList();
            }
        }

        public void AddStudent(Student student)
        {
            using (var entities = new StudentManagementSystemEntities())
            {
                entities.Students.Add(student);
                entities.SaveChanges();
            }
        }

        public void UpdateStudent(Student updatedStudent)
        {
            using (var entities = new StudentManagementSystemEntities())
            {
                var existingStudent = entities.Students.FirstOrDefault(stu => stu.studentId == updatedStudent.studentId);
                if (existingStudent != null)
                {
                    existingStudent.studentName = updatedStudent.studentName;
                    existingStudent.studentCourse = updatedStudent.studentCourse;
                    entities.SaveChanges();
                }
            }
        }

        public void DeleteStudent(int studentId)
        {
            using (var entities = new StudentManagementSystemEntities())
            {
                var student = entities.Students.FirstOrDefault(stu => stu.studentId == studentId);
                if (student != null)
                {
                    entities.Students.Remove(student);
                    entities.SaveChanges();
                }
            }
        }
    }
}