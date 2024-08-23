using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP
{
    internal class Car
    {
        // CONST will be the same for every object created. Needs to be initialized during compile time.
        // READONLY will/can be different for every individual object. Can only be assigned in a constructor or as a field
        // IF it is PRIVATE, then the naming convention will be overwritten by _nameOfVariable
        public static int NumberOfCars = 0;
        public const int NumberOfWeels = 4;

        // Member variable
        // Backing field of the properties
        private string _brand = "";
        private string _model = "";
        private bool _isLuxury;

        // Property
        public string Model { get => _model; set => _model = value; }
        public string Brand { 
            get
            {
                if(_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                } else
                {
                    return _brand;
                }
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered nothing!");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
            }}

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        //Constructor
        public Car(string brand, string model, bool isLuxury)
        {

            Brand = brand;
            Model = model;
            IsLuxury = isLuxury;
            NumberOfCars++;
            
        }
        public Car()
        {
            NumberOfCars++;
        }


        // Methods
        public void Drive() 
        {
            Console.WriteLine($"I'm driving a {Model}...");

        }
    }
}
