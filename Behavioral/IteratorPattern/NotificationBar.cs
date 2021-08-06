using System;

namespace IteratorPattern
{
    public class NotificationBar
    {
        private NotificationCollection _notificationCollection;

        public NotificationBar(NotificationCollection notificationCollection)
        {
            _notificationCollection = notificationCollection;
        }

        public void Print()
        {
            IIterator iterator = _notificationCollection.CreateIterator();

            while (iterator.HasNext())
            {
                var notification = iterator.Next();
                Console.WriteLine($"Notification : {notification.GetNotification()} \n");
            }
        }
    }
}
