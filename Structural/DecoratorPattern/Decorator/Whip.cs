namespace DecoratorPattern.Decorator
{
    public class Whip : ICondiment
    {
        private IBeverage _beverage;

        public string Description { get; set; }

        public Whip(IBeverage beverage) 
        {
            _beverage = beverage;
            Description = beverage.Description + " Whip";
        }

        public double Cost()
        {
            return _beverage.Cost() + 0.25;
        }
    }
}
