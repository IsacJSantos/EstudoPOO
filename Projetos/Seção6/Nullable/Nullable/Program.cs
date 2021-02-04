using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            double a = x ?? 3;
            double b = y ?? 3;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
