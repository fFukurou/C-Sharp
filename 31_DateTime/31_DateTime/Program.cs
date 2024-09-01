namespace _31_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthdate = new DateTime(2004, 01, 20);

            Console.WriteLine($"My birthdate is " + birthdate + "\n");

            // Write  today/now  on screen
            DateTime today = DateTime.Now;
            Console.WriteLine("Today is " + today);
            Console.WriteLine($"Today is a {today.DayOfWeek}\n");

            // Tomorrow
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow is gonna be " + tomorrow);

            // The first day of X year
            Console.WriteLine($"First day of year X: {GetFirstDayOfYear(2978)}");

            // Days in month
            int daysInMonth = DateTime.DaysInMonth(2069, 2);
            Console.WriteLine($"Days in the month of February of 2069: {daysInMonth}");

            // Minute
            int minute = today.Minute;
            Console.WriteLine($"\nThe current minute is {minute}");

            Console.WriteLine($"{today.Hour} o'clock {minute} minutes {today.Second} seconds.");

            // Getting user input
            Console.WriteLine("Write a date in this format yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out  DateTime date))
            {
                TimeSpan daysPassed = today.Subtract(date);
                Console.WriteLine($"Days passed since the input day {input}: {daysPassed.Days}");
            } else
            {
                Console.WriteLine("Wrong input.");
            }


        }

        static DateTime GetTomorrow()
        {
            return DateTime.Now.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
