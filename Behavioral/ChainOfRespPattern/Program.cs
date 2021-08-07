using System;

namespace ChainOfRespPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();

            Console.WriteLine("\nRequested Amount 4600");
            atm.Withdraw(4600);

            Console.WriteLine("\nRequested Amount 1900");
            atm.Withdraw(1900);

            Console.WriteLine("\nRequested Amount 6700");
            atm.Withdraw(6700);

            Console.Read();
        }
    }
}
