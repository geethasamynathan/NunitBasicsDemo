using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrderService
{
 public    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public CustomerType CustomerType { get; set; }
    }
}
