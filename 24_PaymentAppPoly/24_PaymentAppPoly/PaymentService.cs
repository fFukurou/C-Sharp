using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_PaymentAppPoly
{
    internal class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        public PaymentService( IPaymentProcessor processor )
        {
            _processor = processor;

        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }

    }
}
