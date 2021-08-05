using System;

namespace FacadePattern
{
    public class OrderFacade
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Placing order started \n");

            var product = new Product();
            product.GetProductDetails();

            var payment = new Payment();
            payment.MakePayment();

            var invoice = new Invoice();
            invoice.SendInvoice();

            Console.WriteLine("Order placed successfully \n");
        }
    }
}
