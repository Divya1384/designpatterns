using System;

namespace SingletonPattern
{
    public sealed class SingletonEagerLoading
    {
        private static readonly SingletonEagerLoading _instance = new SingletonEagerLoading();
        private static int _counter = 0;

        private SingletonEagerLoading()
        {
        }

        static SingletonEagerLoading()
        {
            _counter++;
        }

        public static SingletonEagerLoading Instance
        {
            get
            {
                return _instance;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine($"Counter value: {_counter}");
            Console.WriteLine(message);
        }
    }
}
