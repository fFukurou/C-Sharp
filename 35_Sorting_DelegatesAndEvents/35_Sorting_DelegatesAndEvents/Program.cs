namespace _35_Sorting_DelegatesAndEvents
{
    public delegate int Comparsion<T> (T x, T y);



    internal class Program
    {

        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
        static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }


        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name =  "Denis", Age = 36 },
                new Person { Name = "Charlie", Age = 35 },
            };

            PersonSorter sorter = new PersonSorter();

            // COMPARING BY AGE
            sorter.Sort(people, CompareByAge);

            foreach(Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            // COMPARING BY NAME
            sorter.Sort(people, CompareByName);

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
        }
    }
}
