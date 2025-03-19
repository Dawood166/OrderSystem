

namespace OrderTakingSystem.Models
{
    public class Order
    {
        required public decimal OrderAmount { get; set; }
        required public string CustomerType { get; set; }

        public decimal Discount { get; set; }
        public decimal TotalAmount { get; set; }
        
        public virtual decimal CalculateDiscount()
        {
        return 0; 
        }
        public virtual decimal CalculateTotalAmount()
        {
        return OrderAmount; 
        }
    }

    public class LoyalCustomerDiscount : Order
    {

        public override decimal CalculateDiscount()
        {
            const decimal fixedDiscountPercentage = 0.10m; 

            if (OrderAmount >= 100 && CustomerType == "Loyal")
            {
                return OrderAmount * fixedDiscountPercentage;
            }

            return 0;
        }

        public override decimal CalculateTotalAmount()
        {
            var discount = CalculateDiscount();
            return OrderAmount - discount;
        }
    }

    public class NewCustomerOrder : Order
    {
        public override decimal CalculateDiscount()
        {
            return 0;
        }

        public override decimal CalculateTotalAmount()
        {
            return OrderAmount; 
        }
    }


}