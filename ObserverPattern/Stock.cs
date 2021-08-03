using System.Collections.Generic;

namespace ObserverPattern
{
    public class Stock : IStock
    {
        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            Price = price;
        }

        public string Symbol { get; set; }

        public double Price { get; set; }
    }
}
