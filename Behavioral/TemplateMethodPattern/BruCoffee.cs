using System;

namespace TemplateMethodPattern
{
    public class BruCoffee : Coffee
    {
        public override void AddCoffeePowder()
        {
            Console.WriteLine("Bru coffee powder added");
        }
    }
}
