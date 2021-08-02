using System;
using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy
{
    public class WhatsAppStrategy : INotificationStrategy
    {
        private string mobileNumber;

        public WhatsAppStrategy(string mobileNumber)
        {
            this.mobileNumber = mobileNumber;
        }

        public void SendNotification()
        {
            Console.WriteLine("Sending WhatsApp notification");
        }
    }
}
