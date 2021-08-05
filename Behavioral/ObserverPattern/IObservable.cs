namespace ObserverPattern
{
    public interface IObservable
    {
        /// <summary>
        /// Register the observer
        /// </summary>
        /// <param name="observer"></param>
        void Subscribe(IObserver observer);

        /// <summary>
        /// Unregister the observer
        /// </summary>
        /// <param name="observer"></param>
        void Unsubscribe(IObserver observer);

        /// <summary>
        /// Notify all observers
        /// </summary>
        void Notify(IStock stock);
    }
}
