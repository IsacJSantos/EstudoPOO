using System;

namespace TimeSpanOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 15, 27);
            TimeSpan t4 = new TimeSpan(55, 2, 15, 27);
            TimeSpan t5 = new TimeSpan(3, 2, 15, 27, 520);


            Console.WriteLine("new TimeSpan(): " + t1);
            Console.WriteLine("new TimeSpan(900000000L): " + t2);
            Console.WriteLine("new TimeSpan(2,15,27): " + t3);
            Console.WriteLine("new TimeSpan('55,2,15,27'): " + t4);
            Console.WriteLine("new TimeSpan(3,2,15,27,520): " + t5);

            Console.WriteLine();
            Console.WriteLine();

            TimeSpan t6 = TimeSpan.FromDays(5);
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromMilliseconds(1);
            TimeSpan t10 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine("TimeSpan.FromDays: " + t6);
            Console.WriteLine("TimeSpan.FromHours: " + t7);
            Console.WriteLine("TimeSpan.FromMinutes: " + t8);
            Console.WriteLine("TimeSpan.FromMilliseconds: " + t9);
            Console.WriteLine("TimeSpan.FromTicks: " + t10);
        }
    }
}
