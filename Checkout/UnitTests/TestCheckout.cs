using System;
using System.Collections.Generic;
using System.Linq;
using Checkout;
using NUnit.Framework;

namespace UnitTests
{
    public class TestCheckout
    {

        [TestCase("", 0)]
        [TestCase("A", 5)]
        [TestCase("ABB", 13)]           //Blah de blah
        [TestCase("ABBB", 21)]
        [TestCase("ABBBCCCC", 25)]
        [TestCase("ABBBCCCCDDD", 33)]
        [TestCase("ABBBCCCCDDDEEEEEE", 73)]
        [TestCase("EEEEEEEEEE", 60)]
        public void GivenListOfItemsCheckThatTotalIsCorrect(string charList, int expectedTotal)
        {
            var checkout = new Checkout.Checkout();
            var itemList = CreateItemListFromCharString(charList);

            Assert.That(checkout.Total(itemList), Is.EqualTo(expectedTotal));
        }

        private List<Item> CreateItemListFromCharString(string chars)
        {
            return chars.Select(c => _itemsToTest[c]).ToList();
        }
        

        private readonly Dictionary<char, Item> _itemsToTest = new Dictionary<char, Item>
        {
            {'A', new Item {Name = "apple", Cost = 5} },
            {'B', new Item {Name = "banana", Cost = 8, BuyQuantity = 2, QuantityFree = 1} },
            {'C', new Item {Name = "Carrot", Cost =2, BuyQuantity = 2, QuantityFree = 1} },
            {'D', new Item {Name = "Weetabix", Cost =4, BuyQuantity = 3, QuantityFree = 1} },
            {'E', new Item {Name = "Booze", Cost =10, BuyQuantity = 5, QuantityFree = 2} },
        };

        [Test]
        public void TestThatADeclinedPaymentThrowsException()
        {
            var checkout = new Checkout.Checkout(new DummyPaymentService());

            Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Payment Declined!"), () => checkout.Pay());
        }

    
	}

	public class DummyPaymentService : IPaymentService
	{
		public bool Pay()
		{
			return true;
		}
	}

}
