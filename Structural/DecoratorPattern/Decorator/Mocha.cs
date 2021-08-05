namespace DecoratorPattern.Decorator
{
    public class Mocha : ICondiment
    {
        private IBeverage _beverage;

        public string Description { get; set; }

        public Mocha(IBeverage beverage) 
        {
            _beverage = beverage;
            Description = beverage.Description + " Mocha";
        }

        public double Cost()
        {
            return _beverage.Cost() + 0.5;
        }
    }
}
