using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Dependencies
{
    internal class Builder
    {
        

        private Hammer _hammer;
        private Saw _saw;

        // Constructor Dependency Injection (DI)
        public Builder(Hammer hammer, Saw saw)
        {
            _hammer = hammer; // Builder is responsible for creating its dependencies
            _saw = saw;
        }

        public void BuildHouse()
        {
            _saw.Use();
            _hammer.Use();
            
            Console.WriteLine("House Built!");
        }
    }
}
