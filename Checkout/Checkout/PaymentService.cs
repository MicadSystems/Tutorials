using System;

namespace Checkout
{
    public class PaymentService
    {
        readonly Random _random = new Random();
        public bool Pay()
        {
            return _random.Next(100) >= 50;
        } 
    }
}