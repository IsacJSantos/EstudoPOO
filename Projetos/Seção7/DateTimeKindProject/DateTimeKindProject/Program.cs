using System;

namespace DateTimeKindProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000,8,15,13,5,58,DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind);
            Console.WriteLine("d1 To Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 To UTC: " + d1.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 To Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 To UTC: " + d2.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 kind: " + d3.Kind);
            Console.WriteLine("d3 To Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 To UTC: " + d3.ToUniversalTime());
        }
    }
}
