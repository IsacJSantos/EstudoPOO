using System;
using System.Globalization;

namespace ExerciciosSeçao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Console.WriteLine("Entre o nome da primeira pessoa");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Entrea idade da primeira pessoa");
            p1.Idade =int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Pessoa p2 = new Pessoa();
            Console.WriteLine("Entre o nome da segunda pessoa");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Entrea idade da segunda pessoa");
            p2.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (p1.Idade >= p2.Idade) 
            {
                Console.WriteLine(p1.Nome + " é a pessoa mais velha");
            }
            else 
            {
                Console.WriteLine(p2.Nome + " é a pessoa mais velha");
            }
        }
    }
}
