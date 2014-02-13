using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurrascoAgil.Utils.Model
{
    class Alimento
    {
        private string _nome { get; set; }
        private float _precoUnitario { get; set; }
        private float _quantidade { get; set; }
        private float _precoFinal { get; set; }

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
