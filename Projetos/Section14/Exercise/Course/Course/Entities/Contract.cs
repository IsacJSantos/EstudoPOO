using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double ContractValue { get; set; }

        public List<Installment> installments = null;

        public Contract(int number, DateTime date, double contractValue)
        {
            Number = number;
            Date = date;
            ContractValue = contractValue;
            installments = new List<Installment>();
        }

        public void InstallmentsView()
        {
            foreach (var item in installments)
            {
                Console.WriteLine($"{item.DueDate} - {item.Amount.ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }

    }
}
