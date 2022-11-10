using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrderService
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public int Amount { get; set; }
    }

     public enum CustomerType
    {
        Basic,
        PremiumCustomer,
        SpecialCustomer
    }
}
