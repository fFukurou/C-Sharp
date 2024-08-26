namespace _21_InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.MakeSound();
            myDog.Eat();

            Collie collie = new Collie();
            collie.GoingNuts();
            collie.Eat();

            Cat cat = new Cat();
            cat.MakeSound();

        }
    }
}
