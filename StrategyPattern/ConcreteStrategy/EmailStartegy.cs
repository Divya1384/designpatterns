using System;
using StrategyPattern.Model;
using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy
{
    public class EmailStartegy : INotificationStrategy
    {
        private string fromMailId;

        private string toMailId;

        private string subject;

        private string messageBody;

        public EmailStartegy(Email email)
        {
            fromMailId = email.FromMailId;
            toMailId = email.ToMailId;
            subject = email.Subject;
            messageBody = email.Subject;
        }

        public void SendNotification()
        {
            Console.WriteLine("Sending email notification");
        }
    }
}
