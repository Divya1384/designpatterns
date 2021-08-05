namespace FactoryPattern
{
    public interface IShapeFactory
    {
        /// <summary>
        /// Creation using type with reflection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IShape GetShape<T>() where T : IShape;

        /// <summary>
        /// Creation using string with reflection
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        IShape GetShape(string shapeType);

        /// <summary>
        /// Creation using a collection
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        IShape CreateShape(string shapeType);
    }
}
