using System;

namespace ProxyPattern
{
    public class RealImage : IImage
    {
        private string FileName { get; set; }

        public RealImage(string fileName)
        {
            FileName = fileName;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading Image : {FileName}");
        }

        public void DisplayImage()
        {
            Console.WriteLine($"Displaying Image : {FileName}");
        }
    }
}
