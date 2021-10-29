using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário");
            Console.WriteLine("Nome");
            f1.Nome= Console.ReadLine();
            Console.WriteLine("Salario");
            f1.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário");
            Console.WriteLine("Nome");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salario");
            f2.Salario = int.Parse(Console.ReadLine());

            string media = ((f1.Salario + f2.Salario) / 2).ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine("A media de salario é: {0} ",media);

        }
    }
}
