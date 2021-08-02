namespace DecoratorPattern.Decorator
{
    public class SteamedMilk : Condiment
    {
        public SteamedMilk(Beverage beverage) : base(beverage)
        {
            Description = beverage.Description + " SteamedMilk";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }
    }
}
