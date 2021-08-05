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

            Singleton fromTeacher2 = Singleton.GetInstance();
            fromTeacher2.PrintDetails("Singleton Eager Loading - From Teacher");

            Singleton fromStudent2 = Singleton.GetInstance();
            fromStudent2.PrintDetails("Singleton Eager loading - From Student");

            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );
            Console.ReadLine();
        }

        private static void PrintTeacherDetails()
        {
            //SingletonWithLock fromTeacher3 = SingletonWithLock.GetInstance();
            //fromTeacher3.PrintDetails("Singleton with single lock - From Teacher");

            //SingletonWithDoubleLock fromTeacher4 = SingletonWithDoubleLock.GetInstance();
            //fromTeacher4.PrintDetails("Singleton with double lock - From Teacher");

            SingletonLazyLoading fromTeacher5 = SingletonLazyLoading.GetInstance();
            fromTeacher5.PrintDetails("Singleton Lazy loading - From Teacher");
        }
        private static void PrintStudentdetails()
        {
            //SingletonWithLock fromStudent3 = SingletonWithLock.GetInstance();
            //fromStudent3.PrintDetails("Singleton with single lock - From Student");

            //SingletonWithDoubleLock fromStudent4 = SingletonWithDoubleLock.GetInstance();
            //fromStudent4.PrintDetails("Singleton with double lock - From Student");

            SingletonLazyLoading fromStudent5 = SingletonLazyLoading.GetInstance();
            fromStudent5.PrintDetails("Singleton Lazy loading - From Student");
        }
    }
}
