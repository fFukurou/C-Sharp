namespace _26_Dependencies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();

            builder.Hammer = hammer;
            builder.Saw = saw;

            builder.BuildHouse();
        }
    }
}
