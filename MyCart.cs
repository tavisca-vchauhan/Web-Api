using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class MyCart
    {
        List<ItemDetails> itemList = new List<ItemDetails>();
        public void AddItemToCart(ItemDetails item)
        {
            itemList.Add(item);
        }

        public void ClearCart()
        {
            itemList.Clear();
            Console.Write("Cart is Clear");
        }

        public void RemoveItemFromCart(ItemDetails item)
        {
            itemList.Remove(item);
        }

        public void TotalItemPrice()
        {
            float Amount = 0;
            for(int i=0;i<itemList.Count;i++)
            {
                Amount += itemList[i].ItemPrice;
            }
            Console.WriteLine(Amount);
        }

        public int TotalItemQuantity()
        {
            int Quantity = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                Quantity += itemList[i].ItemQuantity;
            }
            Console.WriteLine(Quantity);
            return Quantity;
        }

        public void CartDetail()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            for (int i=0;i<itemList.Count;i++)
            {
                Console.WriteLine("ID : "+itemList[0].ItemID);
                Console.WriteLine("Name : "+itemList[0].ItemName);
                Console.WriteLine("Price : "+itemList[0].ItemPrice);
                Console.WriteLine("Quantity : "+itemList[0].ItemQuantity);
                Console.WriteLine("-----------------------------------------------------------------------------");
            }
        }

       

    }
}
