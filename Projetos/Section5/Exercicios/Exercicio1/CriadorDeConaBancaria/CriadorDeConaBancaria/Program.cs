using System;
using System.Globalization;

namespace CriadorDeConaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Haverá depósito Inicial? (s/n)");
                char resposta = char.Parse(Console.ReadLine());         
                if (resposta == 's' || resposta == 'S')
                {
                    Console.WriteLine("Entre um valor para depósito inicial: ");
                    double depoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta1 = new Conta(numero,titular,depoinicial);
                    break;
                }
                else if (resposta == 'n' || resposta == 'N')
                {
                    conta1 = new Conta(numero, titular);
                    break;
                }
                else 
                {
                    Console.WriteLine("*Informe uma resposta válida*");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta1);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados:");
            conta1.Depositar(deposito);
            Console.WriteLine(conta1);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Sacar(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta1);
        }
    }
}
