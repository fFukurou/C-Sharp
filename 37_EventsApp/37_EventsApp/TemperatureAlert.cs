using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_EventsApp
{
    // SUBSCRIBER
    internal class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventsArgs e)
        {
            Console.WriteLine($"Alert: temperature is {e.Temperature} sender is {sender}");
        }
    }
}
