using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6
{
    class ConversorDeMoeda
    {
        public static double Iof = 6;

        public static double Conversor(double cotacao,double dolar)
        {
            double total = dolar * cotacao;
            double imposto = dolar * (Iof / 100) * cotacao;
            return total + imposto;
   
        }
    }
}
