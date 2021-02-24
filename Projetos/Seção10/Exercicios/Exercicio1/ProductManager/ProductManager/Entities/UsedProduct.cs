using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ProductManager.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manuFactureDate)
        : base(name, price)
        {
            ManufactureDate = manuFactureDate;
        }

        public sealed override string PriceTag()
        {
            return Name 
                + " (used) $ " 
                + Price.ToString("F2",CultureInfo.InvariantCulture)
                + $" (Manufactured date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
