using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_EventsApp
{
    internal class TemperatureChangedEventsArgs : EventArgs
    {
        // Property holding the temperature
        public int Temperature { get; }

        // Constructor
        public TemperatureChangedEventsArgs(int temperature)
        {
            Temperature = temperature;
        }

    }
}
