using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP
{
    internal class Customer
    {
        // Static field to hold the next ID available
        private static int nextId = 0;
        // Read-only can be initialized only once, from the constructor
        private readonly int _id;

        // Write-only backing field for our password property --------------->> ONLY USE BACKING FIELD FOR DEFINING THE PROPERTY ITSELF <<-----------
        //private string _password;

        // Making the Id public, but read-only (only has a getter)
        public int Id
        {
            get
            {
                return _id;
            }
        }
        // Write-only property
        public string Password{ set {
                Password = value;
            } }

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        public Customer()
        {
            Name = "DefaultName";
            Address = "No Adress";
            ContactNumber = "No ContactNumber";
            _id = nextId++;
        }

        //Custom Constructors
        public Customer(string name, string adress = "NA", string contactNumber = "NA")
        {
            Name = name;
            Address = adress;
            ContactNumber = contactNumber;
            _id = nextId++;
        }

        // Methods
        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }


        public void GetDetails()
        {
            Console.WriteLine($"\nDetails about the costumer:\nName: {Name}\nAddress: {Address}\nContact Number: {ContactNumber}\nID: {_id}");
        }

        //Stataic method
        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("\nI'm doing some customer stuff");
        }

    }
}
