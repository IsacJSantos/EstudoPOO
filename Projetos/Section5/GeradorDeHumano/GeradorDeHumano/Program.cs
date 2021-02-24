using System;

namespace GeradorDeHumano
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem-vindo ao criador de humanos");
            Console.Write("Digite um nome para seu novo humano: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite uma idade para seu novo humano: ");
            int idade = int.Parse(Console.ReadLine());
           /* Console.WriteLine("Digite uma altura para seu novo humano: ");
            string altura = Console.ReadLine();*/

            Console.WriteLine();
            Humano h = new Humano(nome, idade);
            Console.WriteLine(h.Nome + " tem " + h.Idade + " anos.");
            Console.Write("Mudar nome: ");
            nome = Console.ReadLine();
            h.Nome = nome;
            Console.WriteLine(h.Nome + " tem " + h.Idade + " anos.");

        }
    }
}
