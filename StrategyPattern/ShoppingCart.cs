using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ShoppingCart
    {
        private List<Item> items = new List<Item>();
        
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        private float CalculateTotalAmount()
        {
            float amount = 0;
            foreach(var item in items)
            {
                amount += item.GetItemPrice();
            }
            return amount;
        }

        public void Pay(IPaymentStrategy paymentMethod)
        {
            float amount = CalculateTotalAmount();
            paymentMethod.Pay(amount);
        }
    }
}
