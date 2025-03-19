using Xunit;
using OrderTakingSystem.Models; // Ensure this matches where your main application's models are located

namespace OrderProcessingApp.Tests
{
    public class OrderTests
    {
        [Fact]
        public void CalculateDiscount_LoyalCustomer_Over100_ReturnsDiscount()
        {
            // Arrange
            var order = new LoyalCustomerDiscount { OrderAmount = 150, CustomerType = "Loyal" };

            // Act
            var discount = order.CalculateDiscount();

            // Assert
            Assert.Equal(15, discount); // 10% of 150 is 15
        }

        [Fact]
        public void CalculateTotalAmount_LoyalCustomer_Over100_ReturnsTotal()
        {
            // Arrange
            var order = new LoyalCustomerDiscount { OrderAmount = 150, CustomerType = "Loyal" };

            // Act
            var total = order.CalculateTotalAmount();

            // Assert
            Assert.Equal(135, total); // 150 - 15 (discount) = 135
        }

        [Fact]
        public void CalculateDiscount_NewCustomer_ReturnsZero()
        {
            // Arrange
            var order = new NewCustomerOrder { OrderAmount = 150, CustomerType = "New" };

            // Act
            var discount = order.CalculateDiscount();

            // Assert
            Assert.Equal(0, discount); // No discount for new customers
        }
    }
}
