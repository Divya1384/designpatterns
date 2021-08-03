using System;

namespace AbstractFactoryPattern
{
    public class LinuxButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Painting linux button");
        }
    }
}
