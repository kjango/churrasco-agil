using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurrascoAgil.Utils.Model
{
    class Alimento
    {
        public string _nome { get; set; }
        public float _precoUnitario { get; set; }
        public float _quantidade { get; set; }
        public float _precoFinal { get; set; }

        public Alimento(string nome, float precoUnitario)
        {
            _nome = nome;
            _precoUnitario = precoUnitario;
        }

        public Alimento(string nome, float precoUnitario, float quantidade,
            float precoFinal)
        {
            _nome = nome;
            _precoUnitario = precoUnitario;
            _quantidade = quantidade;
            _precoFinal = precoFinal;
        }
    }
}
