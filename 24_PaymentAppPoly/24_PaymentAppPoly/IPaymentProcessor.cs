using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_PaymentAppPoly
{
    internal interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);

    }
}
