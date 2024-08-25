namespace _18_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null;

            if (age.HasValue)
            {
                Console.WriteLine("Has a value. " + age.Value);

            } else
            {
                Console.WriteLine("is null");
            }
        }
    }
}
