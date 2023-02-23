using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghide
{
    public class Amimal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal make sound");
        }

    }

    public class Dog: Amimal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Go go");
        }
    }
    public class Cat : Amimal
    {
        public override void MakeSound()
        {
            Console.WriteLine("mew mew");
        }
    }
}
