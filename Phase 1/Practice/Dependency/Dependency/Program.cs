using System;
using Dependency;

class Program
{
    static void main()
    {
        Ipayment pm = new CreditCard();
        PaymentProcessing processing = new PaymentProcessing(pm);
        processing.ExecutePayment(1000);
    }
}