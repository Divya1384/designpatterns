using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy
{
    public class PaytmStrategy : IPaymentStrategy
    {
        private string mobileNumber;

        public PaytmStrategy(string mobileNumber)
        {
            this.mobileNumber = mobileNumber;
        }

        public void Pay(float amount)
        {
            Console.WriteLine("Payment done using Paytm");
        }
    }
}
