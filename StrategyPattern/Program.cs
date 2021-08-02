using StrategyPattern.ConcreteStrategy;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var item1 = new Item("AT001", 500);
            var item2 = new Item("BX001", 1500);

            var shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(item1);
            shoppingCart.AddItem(item2);
            shoppingCart.Pay(new PaytmStrategy("9876543210"));

            Console.Read();
        }
    }
}
