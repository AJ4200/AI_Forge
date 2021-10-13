using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AI_Forge_Web_App
{
    public class UserCart
    {
        public int id;
        public int quantity;
        public double price;

        public UserCart(int prod_id, int prod_quantity, double prod_price)
        {
            id = prod_id;
            quantity = prod_quantity;
            price = prod_price;
        }
    }
}