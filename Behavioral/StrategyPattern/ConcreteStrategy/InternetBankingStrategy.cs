using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy
{
    public class InternetBankingStrategy : IPaymentStrategy
    {
        private string userName;
        private string password;

        public InternetBankingStrategy(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public void Pay(float amount)
        {
            Console.WriteLine("Payment done using internet banking");
        }
    }
}
