using System;
using System.Globalization;

namespace RoomRenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] RVector = new Room[10];
            int n = 0;
            Console.Write("How many rooms will be rented? ");
            while (true)
            {
                n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (n <= 10)
                    break;
                else
                    Console.WriteLine("Não há qurtos suficientes. Informe um número de 0 à 10");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent #" + (i+1) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());

                RVector[roomNumber] = new Room(name, email, roomNumber);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < RVector.Length; i++)
            {
                if(RVector[i] != null)
                    Console.WriteLine(RVector[i]);
            }

        }
    }
}
