using System;

namespace CommandPattern
{
    /// <summary>
    /// Receiver
    /// </summary>
    public class Document
    {
        public void Copy()
        {
            Console.WriteLine("Content is copied");
        }

        public void Paste()
        {
            Console.WriteLine("Content is pasted");
        }
    }
}
