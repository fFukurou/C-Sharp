using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Dependencies
{
    internal class Builder : IToolUser
    {
        private Hammer _hammer;
        private Saw _saw;

        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
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
