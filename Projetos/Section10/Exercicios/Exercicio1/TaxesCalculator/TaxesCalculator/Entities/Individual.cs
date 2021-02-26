using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesCalculator.Entities
{
    class Individual: TaxPayers
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIcome, double healthExpenditures)
        : base(name, anualIcome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            if (AnualIncome < 20000.0)
            {
                double tax = AnualIncome * 0.15;
                if (HealthExpenditures > 0)
                {
                    return tax - (HealthExpenditures * 0.5);
                }
                return tax;
            }
            else 
            {
                double tax = AnualIncome * 0.25;
                if (HealthExpenditures > 0)
                {
                    return tax - (HealthExpenditures * 0.5);
                }
                return tax;
            }
        }

    }
}
