namespace _23_Intarfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Eat("food");

            Cat cat = new Cat();
            cat.MakeSound();
            cat.Eat("fish");

        }

    }
}
