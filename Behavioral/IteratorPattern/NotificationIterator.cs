namespace IteratorPattern
{
    public class NotificationIterator : IIterator
    {
        private Notification[] _notifications;
        private int _currentPosition = 0;

        public NotificationIterator(Notification[] notifications)
        {
            _notifications = notifications;
        }

        public bool HasNext()
        {
            if (_currentPosition > _notifications.Length || _notifications[_currentPosition] == null)
            {
                return false;
            }
            return true;
        }

        public Notification Next()
        {
            var notification = _notifications[_currentPosition];
            _currentPosition++;
            return notification;
        }
    }
}
