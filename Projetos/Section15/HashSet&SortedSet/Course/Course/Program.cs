using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 5, 6, 4, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 2, 4 };


            PrintCollection<int>(a);
        }

        static void PrintCollection<T>(IEnumerable<T> collection) 
        {
            foreach (var item in collection)
            {
                Console.Write(item + " ");
                Console.WriteLine("");
            }
        }
    }
}
