using System;
using Course.Services;
namespace Course
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = Teste;
            op += Teste2;
            op += Teste3;

            op.Invoke(a, b);
           
        }

        public static void Teste(double n1, double n2) 
        {
            Console.WriteLine("Testando...: " + n1 + n2);
        }
        public static void Teste2(double n1, double n2)
        {
            Console.WriteLine("Testando2...: " + n1 + n2);
        }
        public static void Teste3(double n1, double n2)
        {
            Console.WriteLine("Testando3...: " + n1 + n2);
        }
    }
}
