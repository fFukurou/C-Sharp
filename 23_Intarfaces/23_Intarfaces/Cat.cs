using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Intarfaces
{
    internal class Cat : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Cat eats {food}");
        }

        public void MakeSound()
        {
            Console.WriteLine("EEEEEHHHHHHHH") ;
        }
    }
}
