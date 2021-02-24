using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            double discount = (price >= 20) ? price * 0.1 : price * 0.05;

            Console.WriteLine(discount.ToString("F2"));

        }
    }
}
