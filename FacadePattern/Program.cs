using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new OrderFacade();
            order.PlaceOrder();
            Console.Read();
        }
    }
}
