using System.Security.Cryptography.X509Certificates;

namespace _16_Lists
{
    internal class Program
    {
        // Making a function to print all the items in a given LIST
        public static void printList<T> (List<T> list) { 
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {

            

            // Declaring a LIST
            List<string> colors = new List<string>();

            // Adding items to the LIST
            colors.Add("Pink");
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("Pink");

            // Removing items from a LIST on a foreach loop
            bool isDeletingSuccessful = colors.Remove("Pink");
            Console.WriteLine(isDeletingSuccessful);
            while (isDeletingSuccessful) 
            {
                isDeletingSuccessful = colors.Remove("Pink");
            }

            Console.WriteLine(isDeletingSuccessful);

            //printList(colors);

            // Declaring and initializing a LIST
            List<string> names = [
                    "Fukurou",
                    "Jin Sakai",
                    "Kratos",
                    "Alloy",
                ];

            names.Add("DoomGuy");

            List<int> numbers = [
                4,7,3,1,5,10,9,8,7,4,2,6,21,25,92,120
                ];

            // SORTING THE ITEMS IN A LIST
            numbers.Sort();

            printList(numbers);

            // ----------------------------------------------------------------
            Predicate<int> isGreaterThanFive = x => x > 5;
            // ----------------------------------------------------------------

            // Preparing a method for a DELEGATE
            static bool isGreaterThanSeven(int x)
            {
                return x > 7;
            }

            Predicate<int> GreaterThanSeven = isGreaterThanSeven;


            // RETURNING ALL NUMBERS THAT ARE GREATER THAN 5 --------->PREDICATES<-------------
            List<int> filteredNumbers = numbers.FindAll(isGreaterThanFive);

            List<int> filteredNumbers2 = numbers.FindAll(isGreaterThanSeven);

            Console.WriteLine("\nFiltering the list to only show numbers greater than 5\n");
            printList(filteredNumbers);

            Console.WriteLine("\nFiltering the list to only show numbers greater than 7\n");
            printList(filteredNumbers2);

            // ANY method
            // Returns bool if condition is met
            bool hasLargeNumber = filteredNumbers2.Any(x => x > 10);

            // Creating a LIST of OBJECT products
            List<Product> products = new List<Product>
            {
                new Product {Name = "Apple", Price = 2.99},
                new Product {Name = "Banana", Price = 1.45},
                new Product {Name = "RTX 4090", Price = 1699.00},
            };
            products.Add(new Product { Name = "i9 14900k", Price = 545.79 });


            Console.WriteLine("\nPrinting the list of object products: \n");
            foreach (Product product in products)
            {
                Console.WriteLine($"\nProduct name: {product.Name}\nProduct price: {product.Price}");
            }

            // Creating a list of 'cheap" products using .Where and lambda to filter the items in the list
            List<Product> cheapProducts =  products.Where(p => p.Price < 100.00).ToList();

            Console.WriteLine("\nPrinting the list of Cheap (<100) object products: \n");
            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"\nCheap product name: {product.Name}\nProduct price: {product.Price}");
            }


        }
    }
}
