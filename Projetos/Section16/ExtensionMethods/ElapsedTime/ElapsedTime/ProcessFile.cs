using System;

namespace ElapsedTime
{
    public class ProcessFile
    {
        public static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 10, 29, 10, 46,0);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
