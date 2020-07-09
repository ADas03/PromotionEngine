using NUnit.Framework;
using PromotionEngine;
using PromotionEngine.BusinessLogic;
using Moq;

namespace PromotionEngineTests
{
    public class ProviderTest
    {
        readonly Provider _provider = new Provider();

        [Test]
        public void Provider()
        {   
            // Adding multiple test case for better code coverage
            
            int totalPrice = _provider.GetTotalPrice(1, 1, 1, 0);
            Assert.AreEqual(100, totalPrice);
            totalPrice = _provider.GetTotalPrice(5, 5, 1, 0);
            Assert.AreEqual(370, totalPrice);
            totalPrice = _provider.GetTotalPrice(3, 5, 1, 1);
            Assert.AreEqual(280, totalPrice);
            totalPrice = _provider.GetTotalPrice(5, 5, 1, 2);
            Assert.AreEqual(395, totalPrice);
            totalPrice = _provider.GetTotalPrice(3, 5, 2, 1);
            Assert.AreEqual(300, totalPrice);
        }
    }
}