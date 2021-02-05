using System;
using System.Globalization;


namespace ModificardorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = Caculator.Sum(3, 2);
            int sum2 = Caculator.Sum(1, 2, 10);
            int sum3 = Caculator.Sum(1, 2, 5, 6, 1);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}
