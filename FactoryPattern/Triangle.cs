using System;

namespace FactoryPattern
{
    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a triangle");
        }
    }
}
