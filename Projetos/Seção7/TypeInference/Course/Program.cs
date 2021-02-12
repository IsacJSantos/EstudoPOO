using System;

namespace TypeInference
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 5;
            var y = 5.6;
            var z = 8.55f;
            var w = "Isac";

            Console.WriteLine(x.GetType() + ": " + x);
            Console.WriteLine(y.GetType() + ": " + y);
            Console.WriteLine(z.GetType() + ": " + z);
            Console.WriteLine(w.GetType() + ": " + w);

        }
    }
}
