using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double soma = 0.0;

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine());
                soma += vect[i];
            }

            //soma = soma / 100;
            Console.WriteLine("AVERAGE HEIGHT = " + (soma/n).ToString("F2"));
            
        }
    }
}
