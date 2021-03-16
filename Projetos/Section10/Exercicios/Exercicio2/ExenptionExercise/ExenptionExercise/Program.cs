using System;
using System.Globalization;
using ExenptionExercise.Entities.Exenptions;
using ExenptionExercise.Entities;

namespace ExenptionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ener account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("WithDraw Limit: ");
            double withDrawLimit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Account ac = new Account(number, holder, withDrawLimit);
            ac.Deposit(balance);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            try
            {
                ac.WithDraw(amount);
                Console.WriteLine("New Balance: " + ac.Balance.ToString("F2"), CultureInfo.InvariantCulture);
            }
            catch (DomainExenption e)
            {
                Console.WriteLine("WithDrow error: " + e.Message);
            }
            catch (FormatException e) 
            {
                Console.WriteLine("Format Error: " + e.Message);
            }

           

        }
    }
}
