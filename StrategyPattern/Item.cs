using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Item
    {
        private string itemCode;
        private float itemPrice;

        public Item(string itemCode, float itemPrice)
        {
            this.itemCode = itemCode;
            this.itemPrice = itemPrice;
        }

        public string GetItemCode()
        {
            return itemCode;
        }

        public float GetItemPrice()
        {
            return itemPrice;
        }
    }
}
