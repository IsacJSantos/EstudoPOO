using System;

namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(f);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double percent = double.Parse(Console.ReadLine());
            f.AumentarSalario(percent);

            Console.WriteLine("Dados atualizados: "+f);
        }
    }
}
