using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationCollection notificationCollection = new NotificationCollection();

            NotificationBar notificationBar = new NotificationBar(notificationCollection);
            notificationBar.Print();

            Console.Read();
        }
    }
}
