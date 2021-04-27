using System;
using System.Globalization;

namespace Exercise.Entities
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Item(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        double TotalPrice()
        {
            return Price * Amount;
        }
        public override string ToString()
        {
            return "Product: "
                + Name
                + ", Total Price: "
                + TotalPrice().ToString(CultureInfo.InvariantCulture);
        }
    }
}
