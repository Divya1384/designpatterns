using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        private Dictionary<string, IShape> shapeCollection = new Dictionary<string, IShape>();

        public ShapeFactory()
        {
            shapeCollection.Add("Circle", new Circle());
            shapeCollection.Add("Square", new Square());
            shapeCollection.Add("Triangle", new Triangle());
        }

        /// <summary>
        /// Using reflection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IShape GetShape<T>() where T : IShape
        {
            return Activator.CreateInstance<T>();
        }

        /// <summary>
        /// Using reflection
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public IShape GetShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
            {
                return null;
            }
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetType(shapeType).FullName;
            return Activator.CreateInstanceFrom(assembly.Location, type).Unwrap() as IShape;
        }

        /// <summary>
        /// Using collection
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public IShape CreateShape(string shapeType)
        {
            return shapeCollection[shapeType];
        }
    }
}
