using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Customer
    {
        static void Main(string[] args)
        {
            MyCart cart = new MyCart();
            ItemDetails item = new ItemDetails();
            Payment payment = new Payment();
            item.ItemID = 1;
            item.ItemName = "Patanjali";
            item.ItemPrice = 15;
            item.ItemQuantity = 2;
            string option = "";
            do
            {
                Console.WriteLine("Enter Add to Add an Item to cart\nRemove to Remove an Item from cart\nShow to show items in cart\nAmount to Calculate Total Price of items\nSize to Check to number of items in Cart\nClear to clear the cart\nPay to Purchase items");
                Console.WriteLine();
                option = Console.ReadLine();
                switch (option)
                {
                    case "Add":
                        cart.AddItemToCart(item);
                        break;
                    case "Remove":
                        Console.WriteLine();
                        cart.RemoveItemFromCart(item);
                        break;
                    case "Show":
                        Console.WriteLine();
                        cart.CartDetail();
                        break;
                    case "Amount":
                        Console.WriteLine();
                        cart.TotalItemPrice();
                        Console.WriteLine();
                        break;
                    case "Clear":
                        Console.WriteLine();
                        cart.ClearCart();
                        Console.WriteLine();
                        break;
                    case "Size":
                        Console.WriteLine();
                        cart.TotalItemQuantity();
                        Console.WriteLine();
                        break;
                    case "Pay":
                        Console.WriteLine("Enter Cash for Cash Payment\nOnline for Online Payment");
                        string mode = Console.ReadLine();
                        Console.WriteLine();
                        payment.ModeOfPurchase(mode);
                        break;
                    default:
                        Console.WriteLine("You have Entered Wrong Values!");
                        break;
                }
            } while (option!= "Pay");
            Console.ReadKey();
        }
    }
}