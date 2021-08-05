namespace DecoratorPattern.Decorator
{
    public class SteamedMilk : ICondiment
    {
        private IBeverage _beverage;

        public string Description { get; set; }

        public SteamedMilk(IBeverage beverage) 
        {
            _beverage = beverage;
            Description = beverage.Description + " SteamedMilk";
        }

        public double Cost()
        {
            return _beverage.Cost() + 0.15;
        }
    }
}
