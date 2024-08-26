using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_InheritanceApp
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound");
        }

    }
}
