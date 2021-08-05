namespace DecoratorPattern
{
    public class Espresso : IBeverage
    {
        public string Description { get; set; }

        public Espresso()
        {
            Description = "Espresso Coffee";
        }

        public double Cost()
        {
            return 1.5;
        }
    }
}
