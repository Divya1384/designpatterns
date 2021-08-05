namespace DecoratorPattern
{
    public class Decaf : IBeverage
    {
        public string Description { get; set; }

        public Decaf()
        {
            Description = "Decaf Coffee";
        }

        public double Cost()
        {
            return 3;
        }
    }
}
