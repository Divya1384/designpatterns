using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IGuiFactory guiWinFactory = new WinFactory();
            IButton button1 = guiWinFactory.CreateButton();
            button1.Paint();
            Console.WriteLine();
            ITextBox textBox1 = guiWinFactory.CreateTexBox();
            textBox1.Paint();
            Console.WriteLine("--------------------------------------");

            IGuiFactory guiLinuxFactory = new LinuxFactory();
            IButton button2 = guiLinuxFactory.CreateButton();
            button2.Paint();
            Console.WriteLine();
            ITextBox textBox2 = guiLinuxFactory.CreateTexBox();
            textBox2.Paint();
            Console.WriteLine("--------------------------------------");

            IGuiFactory guiMacFactory = new MacFactory();
            IButton button3 = guiMacFactory.CreateButton();
            button3.Paint();
            Console.WriteLine();
            ITextBox textBox3 = guiMacFactory.CreateTexBox();
            textBox3.Paint();
            Console.WriteLine("--------------------------------------");

            Console.Read();
        }
    }
}
