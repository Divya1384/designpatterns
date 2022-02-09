using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class FullyLazySingleton
    {
        private int _counter = 0;

        public static FullyLazySingleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private FullyLazySingleton()
        {
            _counter++;
            Console.WriteLine($"Counter value: {_counter}");
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        private class Nested
        {
            static Nested()
            {

            }

            internal static FullyLazySingleton instance = new FullyLazySingleton();
        }
    }
}
