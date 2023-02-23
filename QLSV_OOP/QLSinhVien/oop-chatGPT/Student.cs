using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_chatGPT
{
    internal class Student
    {
        private string name;
        private string studentID;
        private string _class;
        private double gpa;

        public string Name { get => name; set => name = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public string Class { get => _class; set => _class = value; }
        public double Gpa { get => gpa; set => gpa = value; }


        public void Display()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("StudentID " + StudentID);
            Console.WriteLine("Class " + Class);
            Console.WriteLine("GPA" + Gpa);
        }
    }

}
