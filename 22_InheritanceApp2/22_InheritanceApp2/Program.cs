namespace _22_InheritanceApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SEALED KEYWORD: makes it so other classes can't inherit from it

            Employee joe = new Employee("Joe Roagan", 54, "Kick Boxer", 356);
            //joe.DisplayPersonInfo();
            joe.DisplayEmployeeInfo();

            Manager carl = new Manager("Carl Jhonson", 34, "Manager", 41, 3);
            carl.BecomeOlder(5);
            carl.DisplayManagerInfo();

        }
    }
}
