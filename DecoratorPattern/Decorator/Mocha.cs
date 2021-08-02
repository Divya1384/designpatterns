namespace DecoratorPattern.Decorator
{
    public class Mocha : Condiment
    {
        public Mocha(Beverage beverage) : base (beverage)
        {
            Description = beverage.Description + " Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.5;
        }
    }
}
