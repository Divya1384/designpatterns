namespace IteratorPattern
{
    public class Notification
    {
        private string _message;

        public Notification(string message)
        {
            _message = message;
        }

        public string GetNotification()
        {
            return _message;
        }
    }
}
