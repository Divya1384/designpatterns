namespace ObserverPattern
{
    public interface IStock
    {
        string Symbol { get; set; }

        double Price { get; set; }
    }
}
