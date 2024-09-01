namespace _30_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayEnum fr = DayEnum.Kinyoubi;
            DayEnum su = DayEnum.Nichiyoubi;

            DayEnum a = DayEnum.Kinyoubi;

            Console.WriteLine(a == fr);
            Console.WriteLine(DayEnum.Kinyoubi);
            Console.WriteLine((int)DayEnum.Getsuyoubi);
            Console.WriteLine((int)DayEnum.Doyoubi);
        }
    }
}
