using System;

namespace Checkout
{
    public class PaymentService : IPaymentService
    {
        readonly Random _random = new Random();
        public bool Pay()
        {
            return _random.Next(100) >= 50;
        } 
    }
}