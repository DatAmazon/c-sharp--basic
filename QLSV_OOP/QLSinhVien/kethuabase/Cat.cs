using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kethuabase
{
    public class Animal
    {
        public double weight;
        public double height;
        public Animal(double weight, double height)
        {
            this.weight = weight;
            this.height = height;
        }
    }


    public class Cat : Animal
    {
        public static int legs = 4;
        public string  color = "red";

        public Cat(double weight, double height) : base(weight, height)
        {
            //this.weight = weight;
            //this.height = height;
        }
        public void InFor()
        {
            Console.WriteLine("Nang " + weight + " Cao " + height + " leg " + legs + " mau " + color);
        }
    }


}
