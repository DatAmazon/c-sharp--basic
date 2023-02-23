using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    public class Animal
    {
        public double weight;
        public double height;


    }
    public class Cat : Animal
    {
        public static int legs = 4;
    }
    public class BlackCat : Cat
    {
        public static string Color = "Mau den";
        public BlackCat()
        {
            weight = 1.0;
            height = 5;
        }
        public void InFor()
        {
            Console.WriteLine("Nang " + weight + " Cao " + height + " leg " + legs + " mau " + Color);
        }
    }

    public class WhiteCat : Cat
    {
        public static string Color = "Mau trang";
        public WhiteCat()
        {
            weight = 4.0;
            height = 50;
        }
        public void InFor()
        {
            Console.WriteLine("Nang " + weight + " Cao " + height + " leg " + legs + " mau " + Color);
        }

    }
}
