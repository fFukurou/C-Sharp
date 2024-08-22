namespace _14_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating objects of the Car class
            Car bmw = new Car("BMW", "A3", false);
            Car tesla = new Car(brand: "Tesla", model:"i7", true);


            // SETTING BRAND
            bmw.Brand = "";
            tesla.Brand = "Tesla";

            // GETTING MODEL
            Console.WriteLine($"The model of your {bmw.Brand} is {bmw.Model}.");
            Console.WriteLine($"The model of your {tesla.Brand} is {tesla.Model}.\n");

            // Creating objects of the Customer class
            Customer jinSakai = new Customer("Jin Sakai");
            Customer frankTheTank = new Customer("FrankTheTank", "Mainstreet, Russia", "6969420");
            // Default customer with no arguments given
            Customer myCustomer = new Customer();
            Console.WriteLine($"{jinSakai.Name}\n{frankTheTank.Name}\n{myCustomer.Name}\n{jinSakai.Address}");

            // Testing Methods
            tesla.Drive();
            myCustomer.SetDetails(name: "Chris Wilson", address: "GGG");
            Console.WriteLine($"{myCustomer.Address}");

            //Static Methods and Properties
            Customer.DoSomeCustomerStuff();
            jinSakai.GetDetails();
            frankTheTank.GetDetails();
            Console.WriteLine($"\nNumber of cars: {Car.NumberOfCars}");
            Console.WriteLine($"{myCustomer.Name} has an ID of {myCustomer.Id}");
            jinSakai.Password = "HonorDiedOnTheBeach";

        }
    }
}
