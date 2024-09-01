namespace _32_MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ceiling and Floor
            Console.WriteLine($"Ceiling: {Math.Ceiling(15.3)}");
            Console.WriteLine($"Floor: {Math.Floor(15.3)}");

            int num1 = 13;
            int num2 = 9;

            // Min and Max
            Console.WriteLine($"\nLower if num1 {num1} and num2 {num2} is: {Math.Min(num1, num2)}");
            Console.WriteLine($"Higher if num1 {num1} and num2 {num2} is: {Math.Max(num1, num2)}");

            // Power of
            Console.WriteLine($"\n{num1} to the power of {num2} is {Math.Pow(num1,num2)}");

            // PI
            Console.WriteLine($"\nPI is {Math.PI}");

            // SquareROOT
            Console.WriteLine($"\nThe square root of {num2} is {Math.Sqrt(num2)}");

            // Always positive / Absolute
            Console.WriteLine($"\nAlways positive/abs of -25.23 is {Math.Abs(-25.23)}");

            // COS
            Console.WriteLine($"\nCos of {num2} is {Math.Cos(num2)}");

        }
    }
}
