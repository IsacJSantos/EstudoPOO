using System;
using System.IO;
using System.Threading.Tasks;

namespace Escritor
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        char[] cArray = line.ToCharArray();
                        WriteAsync(cArray);
                        Console.ReadLine();
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static async void WriteAsync(char[] cArray)
        {
            for (int i = 0; i < cArray.Length; i++)
            {
                await Task.Delay(30);
                Console.Write(cArray[i]);

            }

        }
    }
}
