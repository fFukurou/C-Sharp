using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Intarfaces
{
    internal class Dog : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Dog ate {food}.");
        }
        public void MakeSound()
        {
            Console.WriteLine("Bark");

        }


    }


}
