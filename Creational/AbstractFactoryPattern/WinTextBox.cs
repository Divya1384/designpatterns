using System;

namespace AbstractFactoryPattern
{
    public class WinTextBox : ITextBox
    {
        public void Paint()
        {
            Console.WriteLine("Painting windows textbox");
        }
    }
}
