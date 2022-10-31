using PRN_Project.Models;
using System;

namespace PRN_Project.ModelView
{
    public class CartItem
    {
        public Product product { get; set; }
        public int amount { get; set; }
        public double TotalMoney => amount * Double.Parse(product.Price);
    }
}
