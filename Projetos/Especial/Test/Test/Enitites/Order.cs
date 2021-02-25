using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Enitites
{
    class Order
    {
        public string ClientName { get; set; }

        List<Product> Product;

        public Order(string clientName)
        {
            ClientName = clientName;
            Product = new List<Product>();
        }

        public void AddProduct(Product product) 
        {
            Product.Add(product);
        }

        public double TotalValue() 
        {
            double sum = 0.0;

            foreach (Product prod in Product)
            {
                sum += prod.Price;
            }

            return sum;
        }
    }
}
