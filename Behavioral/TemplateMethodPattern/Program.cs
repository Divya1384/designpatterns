using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nescafe Coffee Preparation\n");
            Coffee coffee = new NescafeCoffee();
            coffee.PrepareCoffee();

            Console.WriteLine();

            Console.WriteLine("\nBru coffee preparation\n");
            coffee = new BruCoffee();
            coffee.PrepareCoffee();

            Console.Read();
        }
    }
}
