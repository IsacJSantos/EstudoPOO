using System;
using System.Collections.Generic;
using ComparisonCourse.Entities;

namespace ComparisonCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
