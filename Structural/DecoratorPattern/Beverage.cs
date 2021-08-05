namespace DecoratorPattern
{
    public interface IBeverage
    {
        string Description { get; set; }

        double Cost();
    }
}
