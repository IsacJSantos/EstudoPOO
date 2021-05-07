using System.Globalization;
namespace Course.Entities
{
    class Invoice
    {
        public double BasePayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basePayment, double tax)
        {
            BasePayment = basePayment;
            Tax = tax;
        }

        // Propriedade calculada
        public double TotalPayment
        {
            get { return BasePayment + Tax; }
        }

        public override string ToString()
        {
            return "Base paymente: "
                + BasePayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
