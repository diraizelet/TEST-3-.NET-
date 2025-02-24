using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_3__.NET_
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }

    // Step 2: Implement the NoDiscount class
    public class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount;
        }
    }

    // Step 2: Implement the PercentageDiscount class
    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - (totalAmount * _percentage / 100);
        }
    }

    // Step 2: Implement the FixedAmountDiscount class
    public class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly decimal _fixedAmount;

        public FixedAmountDiscount(decimal fixedAmount)
        {
            _fixedAmount = fixedAmount;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount - _fixedAmount;
        }
    }

    // Step 3: Implement the ShoppingCart class
    public class ShoppingCart
    {
        private readonly List<decimal> _items = new List<decimal>();
        private IDiscountStrategy _discountStrategy;

        public void AddItem(decimal price)
        {
            _items.Add(price);
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotal()
        {
            decimal totalAmount = 0;
            foreach (var item in _items)
            {
                totalAmount += item;
            }

            if (_discountStrategy != null)
            {
                totalAmount = _discountStrategy.ApplyDiscount(totalAmount);
            }

            return totalAmount;
        }
    }

}
