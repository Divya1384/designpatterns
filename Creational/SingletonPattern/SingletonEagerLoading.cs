using System;

namespace SingletonPattern
{
    public sealed class SingletonEagerLoading
    {
        private int _counter = 0;

        private SingletonEagerLoading()
        {
            _counter++;
            Console.WriteLine($"Counter value: {_counter}");
        }

        private static readonly SingletonEagerLoading _instance = new SingletonEagerLoading();

        public static SingletonEagerLoading GetInstance()
        {
            return _instance;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
