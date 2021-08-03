namespace ObserverPattern
{
    public interface IObserver
    {
        /// <summary>
        /// Observer name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Receive updates
        /// </summary>
        void Update(IStock stock);
    }
}
