using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.GetShape<Circle>();
            shape1.Draw();

            IShape shape2 = shapeFactory.GetShape("FactoryPattern.Triangle");
            shape2.Draw();

            IShape shape3 = shapeFactory.CreateShape("Square");
            shape3.Draw();

            Console.Read();
        }
    }
}
