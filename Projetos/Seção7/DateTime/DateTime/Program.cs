using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime d1 = new System.DateTime(2021, 11, 25);
            System.DateTime d2 = new System.DateTime(2021, 11, 25, 20, 45, 3);
            System.DateTime d3 = new System.DateTime(2021, 11, 25, 20, 45, 3, 500);

            System.DateTime d4 = System.DateTime.Now;
            System.DateTime d5 = System.DateTime.Today;
            System.DateTime d6 = System.DateTime.UtcNow;

            Console.WriteLine("new DataTime(years, months, days): " + d1);
            Console.WriteLine("new DataTime(years, months, days, hours, minutes, seconds): " + d2);
            Console.WriteLine("new DataTime(years, months, days, hours, minutes, seconds, milliseconds): " + d3);

            Console.WriteLine();

            Console.WriteLine("DataTime.Now: " + d4);
            Console.WriteLine("DataTime.Today: " + d5);
            Console.WriteLine("DataTime.UtcNow: " + d6);

            Console.WriteLine();
            Console.WriteLine();

            System.DateTime d7 = System.DateTime.Parse("2000-08-15");
            System.DateTime d8 = System.DateTime.Parse("2000-08-15 13:05:58");
            System.DateTime d9 = System.DateTime.Parse("15/08/2021");


            Console.WriteLine("DateTime.Parse('2000-08-15'): " + d7);
            Console.WriteLine("DateTime.Parse('2000-08-15 13:05:58'): " + d8);
            Console.WriteLine("DateTime.Parse('15/08/2021'): " + d9);


        }
    }
}
