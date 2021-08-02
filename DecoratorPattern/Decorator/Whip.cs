namespace DecoratorPattern.Decorator
{
    public class Whip : Condiment
    {
        public Whip(Beverage beverage) : base(beverage)
        {
            Description = beverage.Description + " Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.25;
        }
    }
}
