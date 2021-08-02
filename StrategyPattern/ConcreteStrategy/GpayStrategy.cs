using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy
{
    public class GpayStrategy : IPaymentStrategy
    {
        private string upiCode;

        public GpayStrategy(string upiCode)
        {
            this.upiCode = upiCode;
        }

        public void Pay(float amount)
        {
            Console.WriteLine("Payment done using Google Pay");
        }
    }
}
