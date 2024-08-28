using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_InheritanceApp2
{
    internal class Employee: Person
    {
        public string JobTitle { get; set; }
        public int EmployeeID { get; set; }

        // Derived class constructor
        public Employee(string name, int age ,string jobTitle, int employeeID) 
            : base(name, age)
        {
            Console.WriteLine("Employee (derived class) constructor called");
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo(); // Call method from base class
            Console.WriteLine($"Job title: {JobTitle}, Employee ID: {EmployeeID}");
        }

    }
}
