using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Events
{
    internal class EventSubscriber
    {
        public void OnEventRaised(string message)
        {
            Console.WriteLine($"Event received: {message}");
        }
    }
}
