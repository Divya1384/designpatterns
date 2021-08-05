using System;

namespace AbstractFactoryPattern
{
    public class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Painting windows button");
        }
    }
}
