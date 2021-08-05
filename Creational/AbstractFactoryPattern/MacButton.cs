using System;

namespace AbstractFactoryPattern
{
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Painting mac button");
        }
    }
}
