using System;

namespace TemplateMethodPattern
{
    public class NescafeCoffee : Coffee
    {
        public override void AddCoffeePowder()
        {
            Console.WriteLine("Nescafe coffee powder added");
        }
    }
}
