using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_PaymentAppPoly
{
    internal class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
            // Implement the credit card payment logic.

        }
    }
}
