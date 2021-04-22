using System;
using System.IO;
using System.Collections.Generic;
using Exercise.Entities;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            string sourceCsv = @"C:\Users\isacj\Desktop\PaymentList\Source.csv";

            using (StreamReader sr = File.OpenText(sourceCsv))
            {
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split(',');
                    string name = s[0];
                    double price = double.Parse(s[1]);
                    string s1 = s[2];
                    int amount = int.Parse(s1);

                    Item item = new Item(name, price, amount);
                    items.Add(item);
                }
            }

            try
            {
                string summaryPath = Path.GetDirectoryName(sourceCsv) + @"\out";
                string summaryCsv = summaryPath + @"\Summary.csv";
                Directory.CreateDirectory(summaryPath);

                using (StreamWriter sw = File.AppendText(summaryCsv))
                {
                    foreach (var item in items)
                    {
                        sw.WriteLine(item);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
           

        }
    }
}
