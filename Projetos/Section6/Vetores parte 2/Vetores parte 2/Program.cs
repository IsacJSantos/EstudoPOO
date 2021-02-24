using System;
using System.Globalization;


namespace Vetores_parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0.0;

            Product[] p = new Product[n];
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                sum += price;
                p[i] = new Product(name, price);
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
