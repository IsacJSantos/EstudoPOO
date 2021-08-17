using System;

namespace GenericsCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<float> printService = new PrintService<float>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                float x = float.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine($"First: {printService.First()}");
            
        }
    }
}
