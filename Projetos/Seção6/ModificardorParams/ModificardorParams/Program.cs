using System;
using System.Globalization;


namespace ModificardorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Somando números usando o modiciafor Params");
            Console.WriteLine();

            int sum1 = Caculator.Sum(3, 2);
            int sum2 = Caculator.Sum(1, 2, 10);
            int sum3 = Caculator.Sum(1, 2, 5, 6, 1);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.WriteLine();

            Console.WriteLine("Multiplicando numero por 3 usando ref");
            Console.WriteLine();

            int a = 10;
            Caculator.Triple(ref a);
            Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("Multiplicando numero por 3 usando out");
            Console.WriteLine();

            int b = 10;
            int triple;
            Caculator.Triple(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
