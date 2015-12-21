using System;
using System.Collections.Generic;


namespace Checkout
{
    public class Checkout
    {
	    private readonly IPaymentService _paymentService;

	    public Checkout(IPaymentService paymentService)
	    {
		    _paymentService = paymentService;
	    }

	    public Checkout()
	    {
			_paymentService = new PaymentService();

	    }

	    public int Total(List<Item> items)
        {
            var offerList = new Dictionary<string, int>();
            var runningtotal=0;

            foreach (var item in items)
            {
                runningtotal += item.Cost;
                if (item.QuantityFree == 0)
                {
                    continue;
                }

                if (!offerList.ContainsKey(item.Name))
                {
                    offerList.Add(item.Name, 1);
                    continue;
                }

                offerList[item.Name]++;

                if (offerList[item.Name] != item.BuyQuantity)
                {
                    continue;
                }

                runningtotal -= (item.Cost * item.QuantityFree);
                offerList[item.Name] = 0;
            }

            return runningtotal;
        }

        public void Pay()
        {
           

            if (!_paymentService.Pay())
                throw new Exception("Payment Declined!");
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public int BuyQuantity { get; set; } = 1;
        public int QuantityFree { get; set; } = 0;
    }
}
