using OrderTakingSystem.Models;


namespace OrderTakingSystem.Services.Interfaces
{
     public interface IDiscountService
    {
        Order CreateOrder(Order order);
        decimal CalculateDiscount(Order order);
        decimal CalculateTotalAmount(Order order);
    }
}