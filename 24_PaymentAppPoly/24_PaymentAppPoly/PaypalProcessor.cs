using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_PaymentAppPoly
{
    internal class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Paypal payment of {amount}");
            // Implement the Paypal payment logic.

        }
    }
}
