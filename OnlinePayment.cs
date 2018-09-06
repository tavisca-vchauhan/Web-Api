using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class OnlinePayment
    {
        public void SaveCardDetails()
        {
            Console.WriteLine("Enter Your Card Number");
            string cardNumber = Console.ReadLine();
            Console.WriteLine("Enter Card Holder Name");
            string cardHolderName = Console.ReadLine();
            Console.WriteLine("Do you want to save the details for future use ?");
            string option = Console.ReadLine();
            if(option=="y" || option=="Y")
            {
                Console.WriteLine("Card Details Saved successfully");
            }
            else
            {
                cardHolderName = "";
                cardNumber="";
            }
            Console.WriteLine("Your order is placed successfully");

        }
    }
}
