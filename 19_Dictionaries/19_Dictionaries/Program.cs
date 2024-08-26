namespace _19_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - value
            // Declaring and initializing a dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>();

            employees.Add(100, "John Doe");
            employees.Add(101, "Anya Olsen");
            employees.Add(102, "Vladilena Milize");
            employees.Add(103, "Kratos");
            employees.Add(104, "Kaiky Ribeiro");

            // Accessing data from dictionary
            string name = employees[101];
            Console.WriteLine(name);

            // Updating data in a dictionary
            employees[100] = "Bruh replaced";

            // Removing item from a dictionary
            employees.Remove(104);

            // Checking if item already exists
            if(!employees.ContainsKey(106))
            {
                employees.Add(106, "Mike Jike");
            }

            int counter = 100;
            while(employees.ContainsKey(counter))
            {
                counter++;
            }
            employees.Add(counter, "Jesus Christ");

            // TryAdd Method !!1
            bool added = employees.TryAdd(104, "bazinga");
            if(!added)
            {
                Console.WriteLine("\nEmployee with the assigned ID already exists.\n");
            }


            // Looping a dictionary
            foreach (KeyValuePair<int, string> keyValuePair in employees)
            {
                Console.WriteLine(keyValuePair);
                Console.WriteLine($"ID: {keyValuePair.Key}\nName: {keyValuePair.Value}\n");
            }

            Console.WriteLine($"\n________________________________ DICTIONARY OF COMPLEX OBJECTS______________________________\n");

            Dictionary<int, Employee> employees2 = new Dictionary<int, Employee>();

            employees2.Add(1, new Employee("Kratos", 1047, 3672));
            employees2.Add(2, new Employee("John Doe", 28, 1074));
            employees2.Add(3, new Employee("Katarina", 19, 1723));
            employees2.Add(4, new Employee("Fukurou", 20, 13672));

            foreach(var employee in employees2)
            {
                Console.WriteLine($"ID: {employee.Key}  Named: {employee.Value.Name} earns {employee.Value.Salary} and is {employee.Value.Age} years old.");
            }

            Console.WriteLine($"\n_________________________ANOTHER WAY OF INITIALIZING DICTS______________________\n");

            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas",

            };
            // Trying to get a value com a dictionary without crashing the program...
            if(codes.TryGetValue("NY", out string state)) {
                Console.WriteLine(state);
            } else
            {
                Console.WriteLine("Item not in dictionary.");
            }

            foreach(var item in codes)
            {
                Console.WriteLine($"\nThe State for the code {item.Key} is {item.Value}");
            }




            
        }
    }
}
