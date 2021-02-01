using System;

namespace Retangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retangulo");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Medidas do retangulo: ");
            Console.WriteLine("Area = " + r.Area());
            Console.WriteLine("Perimetro = " + r.Perimetro());
            Console.WriteLine("Diagonal = " + r.Diagonal());
        }
    }
}
