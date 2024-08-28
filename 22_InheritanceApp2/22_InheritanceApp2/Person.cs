using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_InheritanceApp2
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; } 
        // Base class constructor

        public Person (string name, int age)
        {
            Console.WriteLine("\nPerson constructor called.");
            Age = age;
            Name = name;
        }

        public void DisplayPersonInfo ()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        /// <summary>
        /// Makes our object older!
        /// </summary>
        /// <param name="years">The parameter that indicates the amount of years the object should age</param>
        /// <returns>Returns the new age after aging</returns>
        public void BecomeOlder (int years)
        {
            Age += years;
        }
    }
}
