using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace GeradorDeHumano
{
    class Humano
    {
        private string _nome;
        public int Idade { get; private set; }
        public string Altura{ get; private set; }

        public Humano()
        {
        }

        public Humano(string nome, int idade)
        {
            _nome = nome;
            Idade = idade;
            Altura = "desconhecida";
        }

        public Humano(string nome, int idade, string altura) : this(nome, idade)
        {
            Altura = altura;
        }
       
        public string Nome
        {
            get{
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 2)
                    _nome = value + "*";
            }
        }


        public override string ToString()
        {
            return _nome + " tem " + Idade + " anos e tem altura " + Altura;
        }
    }
}
