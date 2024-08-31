using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Dependencies
{
    internal interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }
}
