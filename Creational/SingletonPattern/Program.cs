using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Singleton \n");

            Singleton fromTeacher1 = Singleton.GetInstance();
            fromTeacher1.PrintDetails("Singleton - From Teacher");

            Singleton fromStudent1 = Singleton.GetInstance();
            fromStudent1.PrintDetails("Singleton - From Student");

            Console.WriteLine("\nEager Loading Singleton \n");

            SingletonEagerLoading.Instance.PrintDetails("Singleton Eager loading - From Teacher");

            SingletonEagerLoading.Instance.PrintDetails("Singleton Lazy loading - From Student");

            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
                );
            Console.ReadLine();
        }

        private static void PrintTeacherDetails()
        {
            var fromTeacher3 = SingletonWithLock.GetInstance();
            fromTeacher3.PrintDetails("Singleton with single lock - From Teacher");

            var fromTeacher4 = SingletonWithDoubleLock.GetInstance();
            fromTeacher4.PrintDetails("Singleton with double check - From Teacher");

            var fromTeacher5 = SingletonLazyLoading.GetInstance();
            fromTeacher5.PrintDetails("Singleton Lazy loading - From Teacher");

            var fromTeacher6 = FullyLazySingleton.Instance;
            fromTeacher6.PrintDetails("Fully Lazy loading - From Teacher");
        }
        private static void PrintStudentDetails()
        {
            var fromStudent3 = SingletonWithLock.GetInstance();
            fromStudent3.PrintDetails("Singleton with single lock - From Student");

            var fromStudent4 = SingletonWithDoubleLock.GetInstance();
            fromStudent4.PrintDetails("Singleton with double check - From Student");

            var fromStudent5 = SingletonLazyLoading.GetInstance();
            fromStudent5.PrintDetails("Singleton Lazy loading - From Student");

            var fromStudent6 = FullyLazySingleton.Instance;
            fromStudent6.PrintDetails("Fully Lazy loading - From Student");
        }
    }
}
