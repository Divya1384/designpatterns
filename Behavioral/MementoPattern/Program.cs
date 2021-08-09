using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.ledTV = new LedTv("42 inch", "60000Rs", false);

            CareTaker caretaker = new CareTaker();

            caretaker.AddMemento(originator.CreateMemento());
            originator.ledTV = new LedTv("46 inch", "80000Rs", true);

            caretaker.AddMemento(originator.CreateMemento());
            originator.ledTV = new LedTv("50 inch", "100000Rs", true);

            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.WriteLine("\nOriginator restoring to 42 inch LED TV");

            originator.ledTV = caretaker.GetMemento(0).ledTV;

            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.ReadKey();
        }
    }
}
