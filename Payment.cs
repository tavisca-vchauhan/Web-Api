using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
     public class Payment : Mode
    {
        MyCart cart = new MyCart();
        OnlinePayment payment = new OnlinePayment();

        public void ModeOfPurchase(string mode)
        {
                if (mode == "Online")
                {
                    payment.SaveCardDetails();
                }
                else
                {
                    Console.WriteLine("Your Order is successfully placed . ");
                }
            
        }
    }
}
