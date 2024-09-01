namespace _33_MathDateTimeExercise
{
    internal class Program
    {
        public struct Event
        {
            public DateTime startDate;
            public DateTime endDate;

            public Event(DateTime startDate, DateTime endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
            }

            public double GetDuration()
            {
                int duration = endDate.Subtract(startDate).Days;
                return duration;
            }

            public bool IsOverlapping(Event otherEvent)
            {
                if (this.startDate < otherEvent.endDate && this.endDate > otherEvent.startDate)
                {
                    return true;

                } else
                {
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            Event event1 = new Event(new DateTime(2024,05,09), new DateTime(2024,09,09));
            Event event2 = new Event(new DateTime(2024, 05, 12), new DateTime(2024, 09, 10));
            Console.WriteLine(event1.GetDuration());
            Console.WriteLine(event2.GetDuration());
            Console.WriteLine(event1.IsOverlapping(event2));

        }
    }
}
