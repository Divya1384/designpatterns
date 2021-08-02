using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy
{
    public class TextStrategy : INotificationStrategy
    {
        private string mobileNumber;

        public TextStrategy(string mobileNumber)
        {
            this.mobileNumber = mobileNumber;
        }

        public void SendNotification()
        {
            Console.WriteLine("Sending text notification");
        }
    }
}
