using System.Diagnostics;

namespace _20_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine($"Main method is running");

            int? result = 0;

            Console.WriteLine("Type in a number: ");

            try
            {

                int num1 = int.Parse(Console.ReadLine());
                int num2 = 2;
                result = num2 / num1;
                if(num1 == 69)
                {
                    throw new Exception("Bruh");
                }

            } catch(DivideByZeroException ex)
            {
                Console.WriteLine("DON'T DIVIDE BY ZERO!!! " + ex.Message);
                result = 10;

            } catch(FormatException ex)
            {
                Console.WriteLine("A NUMBER! I SAID ENTER A NUMBER!! " + ex.Message);
            } catch(OverflowException ex)
            {
                Console.WriteLine("NUMBER TOO GREAT!!1! " + ex.Message);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message); ;
                Debug.WriteLine(ex.ToString());

            } finally
            {
                Console.WriteLine($"This always executes.");
            }

            Console.WriteLine($"Result: {result}");

           
        }
    }
}
