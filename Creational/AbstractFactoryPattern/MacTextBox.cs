using System;

namespace AbstractFactoryPattern
{
    public class MacTextBox : ITextBox
    {
        public void Paint()
        {
            Console.WriteLine("Painting mac textbox");
        }
    }
}
