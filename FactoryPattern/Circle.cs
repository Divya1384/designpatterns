using System;

namespace FactoryPattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
