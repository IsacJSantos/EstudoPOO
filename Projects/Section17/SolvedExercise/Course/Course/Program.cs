using System;
using System.Collections.Generic;
using Course.Entities;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    list.Add(new Product(fields[0], double.Parse(fields[1], CultureInfo.InvariantCulture)));
                }
            }
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0).Average();
            Console.WriteLine("Avarage price = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
