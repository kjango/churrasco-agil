using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurrascoAgil.Utils.Model
{
    public class Alimento
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private double _precoUnitario;

        public double PrecoUnitario
        {
            get { return _precoUnitario; }
            set { _precoUnitario = value; }
        }
        private double _quantidade;

        public double Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        private double _precoFinal;

        public double PrecoFinal
        {
            get { return _precoFinal; }
            set { _precoFinal = value; }
        }

        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }


        public Alimento(string nome, double precoUnitario)
        {
            _nome = nome;
            _precoUnitario = precoUnitario;
        }

        public Alimento(string nome, double precoUnitario, 
            string tipo, double quantidade)
        {
            _nome = nome;
            _precoUnitario = precoUnitario;
            _tipo = tipo;
            _quantidade = quantidade;
        }
       
    }
}
