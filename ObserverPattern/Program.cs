using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new IBM("IBM", 100);

            stock.AttachInvestor(new Investor("Divya"));
            stock.AttachInvestor(new Investor("Shiju"));

            stock.Price = 120;
            stock.Price = 130;
            stock.Price = 110;
            stock.Price = 150;

            Console.Read();
        }
    }
}
