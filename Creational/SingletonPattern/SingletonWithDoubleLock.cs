using System;

namespace SingletonPattern
{
    public sealed class SingletonWithDoubleLock
    {
        private static SingletonWithDoubleLock _instance = null;

        private int _counter = 0;

        private static readonly object Instancelock = new object();

        public SingletonWithDoubleLock()
        {
            _counter++;
            Console.WriteLine($"Counter value: {_counter}");
        }

        public static SingletonWithDoubleLock GetInstance()
        {
            if (_instance == null)
            {
                lock (Instancelock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonWithDoubleLock();
                    }
                }
            }
            return _instance;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
