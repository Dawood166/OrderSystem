using OrderTakingSystem.Services.Interfaces;
using OrderTakingSystem.Services.Implementations; 
using OrderTakingSystem.Models;


namespace OrderTakingSystem.Services.Implementations
{
     public class DiscountService : IDiscountService
    {
   



        public Order CreateOrder(Order order)
        {
            if (order.CustomerType == "Loyal")
            {
                return new LoyalCustomerDiscount
                {
                    OrderAmount = order.OrderAmount,
                    CustomerType = order.CustomerType
                };
            }
            else
            {
                return new NewCustomerOrder
                {
                    OrderAmount = order.OrderAmount,
                    CustomerType = order.CustomerType
                };
            }
        }

        public decimal CalculateDiscount(Order order)
        {
            return order.CalculateDiscount(); 
        }

        public decimal CalculateTotalAmount(Order order)
        {
            return order.CalculateTotalAmount(); 
        }


    }

    

}