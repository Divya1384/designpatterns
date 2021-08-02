using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class Stock
    {
        private string symbol;
        private double price;
        private List<IInvestor> investors = new List<IInvestor>();

        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void AttachInvestor(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void RemoveInvestor(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void NotifyInvestor()
        {
            foreach(var investor in investors)
            {
                investor.Update(this);
            }
        }

        public string Symbol
        {
            get { return symbol; }
        }
        
        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    NotifyInvestor();
                }
            }
        }
    }
}
