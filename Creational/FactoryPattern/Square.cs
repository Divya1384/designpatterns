using System;

namespace FactoryPattern
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
}
