using System;
using System.Collections.Generic;
using System.IO;
using rev.Entities;

namespace rev
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("14".CompareTo("14.5"));
            /*string path = @"c:\temp\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An Error occurred");
                Console.WriteLine(e.Message);
            }

            */
        }

    }
}
