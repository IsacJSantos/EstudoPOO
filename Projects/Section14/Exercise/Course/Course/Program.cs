using System;
using Course.Services;
using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter number of insatrallmentes: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);
            ContractService.ProcessContract(contract, installments, new PaypalService());
            contract.InstallmentsView();

        }
    }
}
