using System.Globalization;

namespace TaxesCalculator.Entities
{
    abstract class TaxPayers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();

        public override string ToString()
        {
            return Name + ": $" + Taxes().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
