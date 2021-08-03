namespace DecoratorPattern.Decorator
{
    public class Soy : ICondiment
    {
        private IBeverage _beverage;

        public string Description { get; set; }

        public Soy(IBeverage beverage) 
        {
            _beverage = beverage;
            Description = beverage.Description + " Soy";
        }

        public double Cost()
        {
            return _beverage.Cost() + 0.25;
        }
    }
}
