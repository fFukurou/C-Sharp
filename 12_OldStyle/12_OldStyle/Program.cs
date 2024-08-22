namespace _12_OldStyle
{
    internal class Program
    {
        static public int myResult; // Field, or instance variable
        static void Ping()
        {
            Console.WriteLine("Pong");
        }


        static void WriteSomethingSpecific(string myString)
        {
            Console.WriteLine(myString);
        }


        static int Adder(int value1, int value2)
        {
            myResult = value1 + value2;
            return myResult;
        }


        static void Main(string[] args)
        { // MAIN SCOPE

            Ping();
            WriteSomethingSpecific("BRUH");
            Console.WriteLine(Adder(20, 40));

        } // MAIN SCOPE
    }
}
