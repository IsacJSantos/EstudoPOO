using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = 0;
            double? y = x ?? 0.0;

            Console.WriteLine(y);

        }
    }
}
