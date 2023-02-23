using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghide
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Amimal animal = new Amimal();
            animal.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat= new Cat();
            cat.MakeSound();

        }
    }
}
