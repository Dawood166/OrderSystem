using Microsoft.AspNetCore.Mvc;
using OrderTakingSystem.Services.Interfaces;
using OrderTakingSystem.Models;
using OrderTakingSystem.Services.Implementations;


namespace OrderTakingSystem.Controllers
{
     public class OrderController : Controller
    {
        private readonly IDiscountService _discountService;

        public OrderController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public IActionResult OrderEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(Order order)
        {


             if (ModelState.IsValid)
            {
                Order processedOrder = _discountService.CreateOrder(order);

                decimal discount = _discountService.CalculateDiscount(processedOrder);
                decimal totalAmount = _discountService.CalculateTotalAmount(processedOrder);

                processedOrder.Discount = discount;
                processedOrder.TotalAmount = totalAmount;

                return View("Results", processedOrder);
            }

            return View("OrderEntry");
           
        }
    }
}