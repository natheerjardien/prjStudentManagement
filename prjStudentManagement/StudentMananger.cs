using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStudentManagement
{
    public class StudentManager
    {
        private List<Student> students;
        private int nextId;

        public StudentManager()
        {
            students = new List<Student>();
            nextId = 1;
        }

        public Student AddStudent(string name, int age)
        {
            var student = new Student
            {
                iId = nextId++,
                strName = name,
                iAge = age
            };

            students.Add(student);
            return student;
        }

        public List<Student> GetStudents()
        {
            return new List<Student>(students);
        }
    }
}
