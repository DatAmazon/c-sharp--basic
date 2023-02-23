using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Student
    {
        private string id;
        private string firstName;
        private string email;
        private int age;

        public Student() { }
        public Student(string id, string firstName, string email, int age)
        {
            this.id = id;
            this.firstName = firstName;
            this.email = email;
            this.age = age;
        }
        public void SetAge(int newAge)
        {
            if (age < 0 || age > 120)
            {
                Console.WriteLine("Tuoi ban cung cap khong hop le");
            }
            else
            {
                age = newAge;
            }
        }

        public void SetFirstName(string firstName)
        {
            if (firstName.Length > 0 || firstName.Length < 15)
            {
                this.firstName = firstName;
            }
            else
            {
                Console.WriteLine("Ten khong hop le");
            }

        }

        public int GetAge()
        {
            return this.age;
        }
        public string GetFirstName()
        {
            return this.firstName;
        }

        // để truy cập tới mỗi property ta phải khai báo set/get rất bất lợi => .net property giải quyết vấn đề này

        public string Id
        {
            get { return this.id; }
            set
            {
                if (value.Length > 0 || value.Length < 20)// value: gia tri nhap vao
                {
                    this.id = value;
                }
                else
                {
                    Console.WriteLine("ID khong hop le");
                }
            }
        }

    }
}
