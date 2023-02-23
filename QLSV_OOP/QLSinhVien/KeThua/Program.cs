using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlackCat cat = new BlackCat();
            cat.InFor();

            WhiteCat cat1 = new WhiteCat();
            cat1.InFor();
            Console.WriteLine();
        }
    }
}
