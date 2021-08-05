using System;

namespace ObserverPattern
{
    public class Investor : IObserver
    {
        public string Name { get; set; }

        public Investor(string name)
        {
            Name = name;
        }

        public void Update(IStock stock)
        {
            Console.WriteLine($"Notified {Name} of {stock.Symbol}'s change to ${stock.Price}");
        }
    }
}
