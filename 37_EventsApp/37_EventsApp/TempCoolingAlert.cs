using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_EventsApp
{
    internal class TempCoolingAlert
    {
        public void OnTemperatureChanged(object sender, TemperatureChangedEventsArgs e)
        {
            Console.WriteLine($"TEMP COOLING ALERT: temperature is {e.Temperature} sender is {sender}");
        }
    }
}
