using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> _shapeMap = new Dictionary<string, IShape>();

        public static IShape GetShape(string shapeType)
        {
            //If a circle object already exist it will not create it again. It will use the same object and set the color property
            IShape shape = null;
            if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                _shapeMap.TryGetValue("circle", out shape);
            }
            if (shape == null)
            {
                shape = new Circle();
                _shapeMap.Add("circle", shape);
                Console.WriteLine("Creating circle object with out any color in shapefactory");
            }
            return shape;
        }
    }
}
