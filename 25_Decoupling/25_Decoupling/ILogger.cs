using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Decoupling
{
    internal interface ILogger
    {
        public void Log(string message);
    }
}
