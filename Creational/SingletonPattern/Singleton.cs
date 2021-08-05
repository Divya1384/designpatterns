using System;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private int _counter = 0;

        private Singleton()
        {
            _counter++;
            Console.WriteLine($"Counter value: {_counter}");
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
