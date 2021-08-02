namespace DecoratorPattern.Decorator
{
    public class Soy : Condiment
    {
        public Soy(Beverage beverage) : base (beverage)
        {
            Description = beverage.Description + " Soy";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.25;
        }
    }
}
