using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image1 = new ProxyImage("Tiger Image");

            Console.WriteLine("----------- Loading for the first time ----------- \n");
            image1.DisplayImage();
            Console.WriteLine("\n----------- Loading for the second time ----------- \n");
            image1.DisplayImage();

            IImage image2 = new ProxyImage("Lion Image");

            Console.WriteLine("\n----------- Loading for the first time ----------- \n");
            image2.DisplayImage();
            Console.WriteLine("\n----------- Loading for the second time ----------- \n");
            image2.DisplayImage();
            Console.WriteLine("\n----------- Loading for the third time ----------- \n");
            image2.DisplayImage();

            Console.Read();
        }
    }
}
