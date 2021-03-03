using System;

namespace ExenptionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException) 
            {
                Console.WriteLine("Divide por zero não, po!");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Você precisa informar um número");
            }
        }
    }
}
