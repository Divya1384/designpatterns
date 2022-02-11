using System;

namespace SingletonPattern
{
    public sealed class SingletonLazyLoading
    {
        private int _counter = 0;

        private static readonly Lazy<SingletonLazyLoading> Instancelock = new Lazy<SingletonLazyLoading>(() => new SingletonLazyLoading());

        private SingletonLazyLoading()
        {
            _counter++;
            Console.WriteLine($"Counter value: {_counter}");
        }

        public static SingletonLazyLoading GetInstance()
        {
            return Instancelock.Value;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
