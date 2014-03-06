using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurrascoAgil.Utils.Model
{
    class Alimento
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private float _precoUnitario;

        public float PrecoUnitario
        {
            get { return _precoUnitario; }
            set { _precoUnitario = value; }
        }
        private float _quantidadeBase;

        public float QuantidadeBase
        {
            get { return _quantidadeBase; }
            set { _quantidadeBase = value; }
        }
        private float _precoFinal;

        public float PrecoFinal
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


        public Alimento(string nome, float precoUnitario)
        {
            _nome = nome;
            _precoUnitario = precoUnitario;
        }

        public Alimento(string nome, float precoUnitario, 
            string tipo, float quantidade)
        {
            _nome = nome;
            _precoUnitario = precoUnitario;
            _tipo = tipo;
            _quantidadeBase = quantidade;
        }
       
    }
}
