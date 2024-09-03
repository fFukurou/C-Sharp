namespace _37_EventsApp
{

    //public delegate void TemperatureChangeHandler(string message);


    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();
            TempCoolingAlert alert2 = new TempCoolingAlert();
            monitor.TemperatureChanged += alert.OnTemperatureChanged;
            monitor.TemperatureChanged += alert2.OnTemperatureChanged;

            monitor.Temperature = 20;
            Console.WriteLine($"Please enter the temperature: ");
            monitor.Temperature = int.Parse(Console.ReadLine());
        }
    }
}
