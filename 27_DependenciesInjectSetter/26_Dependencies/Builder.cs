using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Dependencies
{
    internal class Builder
    {

        public Hammer Hammer { get; set; }
        public Saw Saw { get; set; }

        // Setter Dependency Injection (DI)

        public void BuildHouse()
        {
            Saw.Use();
            Hammer.Use();
            
            Console.WriteLine("House Built!");
        }
    }
}
