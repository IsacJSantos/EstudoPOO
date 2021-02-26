using System;
using System.Globalization;
using System.Collections.Generic;
using TaxesCalculator.Entities;

namespace TaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayers> list = new List<TaxPayers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIcome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpen = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIcome, healthExpen));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIcome, numberOfEmployees));
                }
            }
            Console.WriteLine();

            Console.WriteLine("TAXES PAID:");

            foreach (TaxPayers payer in list)
            {
                Console.WriteLine(payer);
            }

            
            double sum = 0.0;
            foreach (TaxPayers payer in list)
            {
                sum += payer.Taxes();
            }
            Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
