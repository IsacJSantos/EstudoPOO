
using System;
namespace PrimeiroProjeto
{
    class Triangulo
    {
        public double A, B, C; 

        public double CalcularArea() 
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}
