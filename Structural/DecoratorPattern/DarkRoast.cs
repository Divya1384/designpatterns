namespace DecoratorPattern
{
    public class DarkRoast : IBeverage
    {
        public string Description { get; set; }

        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public double Cost()
        {
            return 2.2;
        }
    }
}
