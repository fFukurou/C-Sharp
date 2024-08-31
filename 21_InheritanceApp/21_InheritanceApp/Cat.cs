using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_InheritanceApp
{
    internal class Cat: Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Cat is meowing...");
        }
    }
}
