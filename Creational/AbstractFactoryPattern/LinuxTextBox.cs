using System;

namespace AbstractFactoryPattern
{
    public class LinuxTextBox : ITextBox
    {
        public void Paint()
        {
            Console.WriteLine("Painting linux textbox");
        }
    }
}
