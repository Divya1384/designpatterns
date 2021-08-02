namespace DecoratorPattern.Decorator
{
    public class Condiment : Beverage
    {
        protected Beverage beverage;

        public Condiment(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return beverage.Cost();
        }
    }
}
