using DecoratorPattern.Decorator;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new Espresso();
            Console.WriteLine($"{beverage1.Description} - ${beverage1.Cost()}");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.Description} - ${beverage2.Cost()}");

            Beverage beverage3 = new HouseBlend();
            beverage3 = new SteamedMilk(beverage3);
            Console.WriteLine($"{beverage3.Description} - ${beverage3.Cost()}");

            Console.Read();
        }
    }
}
