using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_EventsApp
{
    internal class TemperatureMonitor
    {

        public event EventHandler<TemperatureChangedEventsArgs> TemperatureChanged;

        //public event TemperatureChangeHandler OnTemperatureChanged;

        private int _temperature;
        public int Temperature { get { return _temperature; }
            set {
                if(_temperature != value)
                {
                    // RAISE EVENT!!!
                    _temperature = value;
                    OnTemperatureChanged(new TemperatureChangedEventsArgs(_temperature));
                }
                
            } }

        protected virtual void OnTemperatureChanged(TemperatureChangedEventsArgs e)
        {
            // Letting every subscriber know!
            TemperatureChanged?.Invoke(this, e);
        }

    }
}
