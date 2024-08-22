namespace WeaterSimulator

{
    internal class Program
    {
        // Calculating the avarage temperature in the list of temperatures
        static double AvarageTemp(int[] temperatures)
        {
            double total = 0;
            foreach(int temp in temperatures)
            {
                total += temp;
            }
            total /= temperatures.Length;
            return total;
        }


        // Calculating the minimum temperature myself
        static double MinTemperature(int[] temperatures) { 
            double min = temperatures[0];

            foreach(var temp in temperatures)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }
            return min;
        }


        // Getting the most common temperature (moda)
        // Could optimize it by checking whether a weather was already checked or not. e.g: if "Snowy" was already checked and we know how many times it appears
        // Don't check it again; instead go to the next iteration of the i loop.
        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {

                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
                }

            }
            return mostCommon;
        }


        static void Main(string[] args)
        { // MAIN SCOPE
            Console.WriteLine("Enter the number of days to simulate");
            int days  = int.Parse(Console.ReadLine());

            int[] temperatures = new int[days];
            string[] conditions = { "Sunny", "Cloudy", "Snowy", "Rainy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperatures[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            double avarageTemperature = AvarageTemp(temperatures);
            double maxTemperature = temperatures.Max();
            double minTemperature = temperatures.Min();
            double minTemperature2 = MinTemperature(temperatures);
            string mostCommonCondition = MostCommonCondition(weatherConditions);
            Console.WriteLine($"\nThe avarage temperature for these days is {avarageTemperature:F2} ºC");
            Console.WriteLine($"\nThe maximum temperature is gonna be {maxTemperature:F2} ºC");
            Console.WriteLine($"\nThe minimum temperature is gonna be {minTemperature:F2} ºC");
            Console.WriteLine($"\nThe minimum temperature is gonna be {minTemperature2:F2} ºC");
            Console.WriteLine($"\nThe most common condition is gonna be {mostCommonCondition}");

        } // MAIN SCOPE
    }
}
