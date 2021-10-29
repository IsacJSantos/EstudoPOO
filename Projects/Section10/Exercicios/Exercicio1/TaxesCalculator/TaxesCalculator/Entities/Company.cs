using System;
using System.Collections.Generic;
using System.Text;

namespace TaxesCalculator.Entities
{
    class Company : TaxPayers
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIcome, int numberOfEmployees)
        :base(name,anualIcome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Taxes()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
