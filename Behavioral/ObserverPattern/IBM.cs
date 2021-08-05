using System.Collections.Generic;

namespace ObserverPattern
{
    public class IBM : IObservable
    {
        private List<IObserver> investors = new List<IObserver>();

        private double CurrentPrice { get; set; }

        public void Subscribe(IObserver observer)
        {
            investors.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            investors.Remove(observer);
        }

        public void Notify(IStock stock)
        {
            if (CurrentPrice == stock.Price)
            {
                return;
            }

            foreach(var investor in investors)
            {
                investor.Update(stock);
            }
        }
    }
}
