using System;
using System.IO;

namespace Course
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            Console.Write("Arraste o arquivo para leitura: ");
            string sourcePath = Console.ReadLine();
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"Escreva a linha {i+1}: ");
                        string line = Console.ReadLine();
                        sw.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
