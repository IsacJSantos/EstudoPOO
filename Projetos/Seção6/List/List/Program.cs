using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();

            nameList.Add("Isac");
            nameList.Add("Lucas");
            nameList.Add("Ivis");
            nameList.Add("Matheus");
            nameList.Add("Hugo");
            nameList.Add("Tamara");
            nameList.Add("Viviane");
            nameList.Add("Ivone");
            nameList.Add("Diego");
            nameList.Add("Veronica");
            nameList.Add("Tamires");
            nameList.Add("Daiane");
            nameList.Add("Solange");
            nameList.Add("Dilma");
            nameList.Add("Vilma");
            nameList.Add("Jonathan");
            nameList.Add("Gabriel");
            nameList.Add("Fabio");
            nameList.Add("Draquiosvaldo");
            nameList.Add("Anatonaldoridio");
            nameList.Insert(5, "Ivonete");
            nameList.Insert(7, "Iris");

            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Count of names in the list: " + nameList.Count);
            Console.WriteLine("------------------------");
            Console.WriteLine("Removing names larger than 7 characters: ");

            nameList.RemoveAll(x => x.Length > 7);
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Count of names in the list: " + nameList.Count);
            Console.WriteLine("------------------------");
            Console.WriteLine("Getting all name which starts with 'I': ");
            List<string> iNames = nameList.FindAll(x => x[0] == 'I');
            foreach (var iname in iNames)
            {
                Console.WriteLine(iname);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Getting all name which lenght equals 5 : ");
            List<string> fiveLenghtNames = nameList.FindAll(x => x.Length == 5);
            foreach (var name in fiveLenghtNames)
            {
                Console.WriteLine(name);
            }

        }
    }
}
