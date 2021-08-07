using System;
using System.Collections;

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
            IEnumerator iterator = _notificationCollection.GetEnumerator();

            while (iterator.MoveNext())
            {
                var notification = (Notification) iterator.Current;
                Console.WriteLine($"Notification : {notification.GetNotification()} \n");
            }
        }
    }
}
