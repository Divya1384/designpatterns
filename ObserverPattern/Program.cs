using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ibm = new IBM();

            ibm.Subscribe(new Investor("Divya"));
            ibm.Subscribe(new Investor("Shiju"));

            ibm.Notify(new Stock("IBM", 120));
            ibm.Notify(new Stock("IBM", 130));
            ibm.Notify(new Stock("IBM", 110));
            ibm.Notify(new Stock("IBM", 150));

            Console.Read();
        }
    }
}
