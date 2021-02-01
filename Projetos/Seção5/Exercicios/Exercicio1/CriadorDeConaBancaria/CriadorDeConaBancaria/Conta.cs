using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CriadorDeConaBancaria
{
    class Conta
    {
        private const double _taxaSaque = 5.00;


        public double Saldo { get; private set; }
        public int Numero { get; private set; }
        public string Titular { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, double depoInicial) : this(numero, titular)
        {
            if(depoInicial > 0)
            Saldo = depoInicial;
        }

        public void Depositar(double deposito)
        {
            if (deposito > 0)
                Saldo += deposito;
        }
        public void Sacar(double saque)
        {
            if (saque > 0)
                Saldo -= (saque + _taxaSaque);
        }

        public override string ToString()
        {
            return "Conta: " 
                + Numero 
                + ", Titular: " 
                + Titular 
                + ", Saldo: $" 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
