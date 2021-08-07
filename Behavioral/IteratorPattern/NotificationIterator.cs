using System.Collections;

namespace IteratorPattern
{
    public class NotificationIterator : IEnumerator
    {
        private Notification[] _notifications;
        private int _currentPosition = 0;
        private int _incrementValue = 1;

        public NotificationIterator(Notification[] notifications)
        {
            _notifications = notifications;
        }

        public object Current { get; set; }

        public bool MoveNext()
        {
            if (_currentPosition > _notifications.Length || _notifications[_currentPosition] == null)
            {
                return false;
            }
            Current = _notifications[_currentPosition];
            _currentPosition += _incrementValue;
            return true;
        }

        public void Reset()
        {
            _currentPosition = 0;
        }
    }
}
