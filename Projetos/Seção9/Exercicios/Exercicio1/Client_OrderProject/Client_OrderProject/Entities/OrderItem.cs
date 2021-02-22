using System;
using System.Collections.Generic;
using System.Text;

namespace Client_OrderProject.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem(string productName,int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
            Product = new Product(productName,price);
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}
