using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    internal class PaymentProcessing
    {
        private readonly Ipayment _payment;

        public PaymentProcessing(Ipayment pm)
        {
            _payment = pm;
        }

        public void ExecutePayment(decimal amount)
        {
            _payment.ProcessPayment(amount);
        }
    }
}
