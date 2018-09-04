using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    interface CartDetails
    {
        void TotalItemQuantity();
        void TotalItemPrice();
        void AddItemToCart();
        void RemoveItemFromCart();
        void ClearCart();
        void MyCart();

    }
}
