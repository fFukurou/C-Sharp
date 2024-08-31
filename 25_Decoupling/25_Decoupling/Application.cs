using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Decoupling
{
    internal class Application
    {
        private readonly ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.Log("Work Started\n");
            // DO ALL THE WORK!
            _logger.Log("Work Done. Good job.");
        }
    }
}
