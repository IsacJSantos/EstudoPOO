using System;

namespace DataTimeOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2021, 11, 25);
            DateTime d2 = new DateTime(2021, 11, 25, 20, 45, 3);
            DateTime d3 = new DateTime(2021, 11, 25, 20, 45, 3, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine("new DataTime(years, months, days): " + d1);
            Console.WriteLine("new DataTime(years, months, days, hours, minutes, seconds): " + d2);
            Console.WriteLine("new DataTime(years, months, days, hours, minutes, seconds, milliseconds): " + d3);

            Console.WriteLine();

            Console.WriteLine("DataTime.Now: " + d4);
            Console.WriteLine("DataTime.Today: " + d5);
            Console.WriteLine("DataTime.UtcNow: " + d6);

            Console.WriteLine();
            Console.WriteLine();

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2021");


            Console.WriteLine("DateTime.Parse('2000-08-15'): " + d7);
            Console.WriteLine("DateTime.Parse('2000-08-15 13:05:58'): " + d8);
            Console.WriteLine("DateTime.Parse('15/08/2021'): " + d9);

        }
    }
}
