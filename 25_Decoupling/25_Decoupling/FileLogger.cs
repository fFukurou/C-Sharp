using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Decoupling
{
    internal class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // The @ sign in C# is used to denote a verbatim string literal
            string directoryPath = @"C:\Users\supev\source\repos\udemy\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, message + "\n");
        }
    }
}
