using System;

namespace FlyweightPattern
{
    public class Circle : IShape
    {
        public string Color { get; set; }
        private int _xCor = 10;
        private int _yCor = 20;
        private int _radius = 30;

        public void SetColor(string color)
        {
            this.Color = color;
        }

        public void Draw()
        {
            Console.WriteLine(" Circle: Draw() [Color : " + Color + ", X Cor : " + _xCor + ", YCor :" + _yCor + ", Radius :" + _radius);
        }
    }
}
