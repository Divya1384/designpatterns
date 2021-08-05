using System;
using StrategyPattern.Model;
using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy
{
    public class CreditCardStrategy : IPaymentStrategy
    {
        public string Name;
        public string CardNumber;
        public string CvvNumber;
        public string ExpiryMonth;
        public string ExpiryYear;

        public CreditCardStrategy(CardInfo cardInfo)
        {
            Name = cardInfo.Name;
            CardNumber = cardInfo.CardNumber;
            CvvNumber = cardInfo.CvvNumber;
            ExpiryMonth = cardInfo.ExpiryMonth;
            ExpiryYear = cardInfo.ExpiryYear;
        }

        public void Pay(float amount)
        {
            Console.WriteLine("Payment done using credit card");
        }
    }
}
