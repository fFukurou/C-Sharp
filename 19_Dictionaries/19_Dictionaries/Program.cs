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

        }
    }
}
