using System;

namespace SingletonPattern
{
    public sealed class SingletonWithLock
    {
        private static SingletonWithLock _instance = null;

        private int _counter = 0;

        private static readonly object Instancelock = new object();

        public SingletonWithLock()
        {
            _counter++;
            Console.WriteLine($"Counter value: {_counter}");
        }

        public static SingletonWithLock GetInstance()
        {
            lock(Instancelock)
            {
               if (_instance == null)
                {
                    _instance = new SingletonWithLock();
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
