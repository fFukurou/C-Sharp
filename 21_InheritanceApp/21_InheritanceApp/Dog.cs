﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_InheritanceApp
{
    internal class Dog: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog is Barking...");
        }
    }
}