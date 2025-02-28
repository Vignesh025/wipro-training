using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    internal interface Ipayment
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCard : Ipayment
    {
        public void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class Upi : Ipayment
    {
        public void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}   
