using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryPattern
{
    public class ShapeFactory : IShapeFactory
    {
        private Dictionary<string, IShape> shapeCollection = new Dictionary<string, IShape>();

        public ShapeFactory()
        {
            shapeCollection.Add("Circle", new Circle());
            shapeCollection.Add("Square", new Square());
            shapeCollection.Add("Triangle", new Triangle());
        }

        /// <summary>
        /// A way to create object using reflection 
        /// by passing the exact Object Type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IShape GetShape<T>() where T : IShape
        {
            return Activator.CreateInstance<T>();
        }

        /// <summary>
        /// A way to create object using reflection 
        /// by passing a string 
        /// namespace.ObjectType
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
        /// A way to create object using a collection
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public IShape CreateShape(string shapeType)
        {
            return shapeCollection[shapeType];
        }
    }
}
