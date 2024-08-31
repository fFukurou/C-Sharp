using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Decoupling
{
    internal class DatabaseLogger : ILogger
    {
        
        public void Log(string message)
        {
            // Implement logic to log a message to a database
            Console.WriteLine($"Logging to database:  {message}");
        }
    }
}
