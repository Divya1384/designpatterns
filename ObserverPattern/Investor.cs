using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Investor : IInvestor
    {
        private string name;

        public Stock Stock { get; set; }

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified {name} of {stock.Symbol}'s change to ${stock.Price}");
        }
    }
}
