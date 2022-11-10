using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrderService
{
  public  class CustomerOrderservice1
    {
         public void ApplyDiscount(Customer customer , Order order)
        {
            if(customer.CustomerType==CustomerType.PremiumCustomer)
            {
                order.Amount = order.Amount - ((order.Amount * 10) / 100);

            }
            else if(customer.CustomerType==CustomerType.SpecialCustomer)
            {
                order.Amount = order.Amount - ((order.Amount * 20) / 100);

            }
        }
    }
}
