using System;

namespace Retangulos
{
    class Retangulo
    {
        public double Largura;
        public double Altura;


        public double Area() 
        {
            return Largura * Altura;
        }

        public double Perimetro() 
        {
            return (Altura * 2) + (Largura * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }
    }
}
