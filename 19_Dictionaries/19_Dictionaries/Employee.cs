using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Dictionaries
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        

        public Employee(string name, int age, int salary) {

            Name = name;
            Age = age; 
            Salary = salary;

        }
    }
}
