using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        public Customer()
        {
            Name = "DefaultName";
            Address = "No Adress";
            ContactNumber = "No ContactNumber";
        }

        //Custom Constructors
        public Customer(string name, string adress, string contactNumber)
        {
            Name = name;
            Address = adress;
            ContactNumber = contactNumber;
        }
        public Customer(string name)
        {
            Name = name;
        }
    }
}
