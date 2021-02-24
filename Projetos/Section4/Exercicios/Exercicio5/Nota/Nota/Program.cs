using System;

namespace Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            double NotaCorte = 100;

            Console.WriteLine("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota Final: " + a.SomarNotas());

            if (a.SomarNotas() >= NotaCorte) 
            {
                Console.WriteLine("Aprovado");
            }
            else 
            {
                Console.WriteLine("Reprovado");
                double restante = NotaCorte - a.SomarNotas();
                Console.WriteLine("Faltaram " + restante +" pontos.");
            }
        }
    }
}
