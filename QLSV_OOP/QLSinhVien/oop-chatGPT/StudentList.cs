using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_chatGPT
{
    public class StudentList
    {
        private List<Student> students;

        public StudentList()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(string studentId)
        {
            students.RemoveAll(s => s.StudentId == studentId);
        }

        public Student FindStudentById(string studentId)
        {
            return students.FirstOrDefault(s => s.StudentId == studentId);
        }

        public List<Student> FindStudentsByName(string name)
        {
            return students.Where(s => s.Name.Contains(name)).ToList();
        }

        public void DisplayAllStudents()
        {
            foreach (var student in students)
            {
                student.Display();
                Console.WriteLine();
            }
        }
    }
}
