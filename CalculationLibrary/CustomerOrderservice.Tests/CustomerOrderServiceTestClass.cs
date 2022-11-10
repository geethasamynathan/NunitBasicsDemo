using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CustomerOrderService;
namespace CustomerOrderservice.Tests
{
    [TestFixture]
    class CustomerOrderServiceTestClass
    {
        [TestCase]
        public void when_PremiumCustomer_Expect_10PercentDiscount()
        {
            //arrange
            Customer customer = new Customer()
            {
                CustomerId = 1,
                CustomerName = "Jeevitha",
                CustomerType = CustomerType.PremiumCustomer
            };

            Order order = new Order()
            {
                OrderId = 1,
                ProductId = 2002,
                ProductQuantity = 1,
                Amount = 1000
            };

            CustomerOrderservice1 customerOrderService = new CustomerOrderservice1();

            //Act
            customerOrderService.ApplyDiscount(customer, order);

            //assert
            Assert.AreEqual(order.Amount, 900);
        }
    }
}
