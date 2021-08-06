namespace IteratorPattern
{
    public class NotificationCollection : ICollection
    {
        private int MaxCount = 10;
        private int count = 0;

        Notification[] _notifications;

        public NotificationCollection()
        {
            _notifications = new Notification[MaxCount];

            AddItem(new Notification("Notification 1"));
            AddItem(new Notification("Notification 2"));
            AddItem(new Notification("Notification 3"));
        }

        public void AddItem(Notification notification)
        {
            _notifications[count] = notification;
            count++;
        }

        public IIterator CreateIterator()
        {
            return new NotificationIterator(_notifications);
        }
    }
}
