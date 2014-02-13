using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurrascoAgil.Utils.Model
{
    class Quantidade
    {
        public float _qtdeMulher { get; set; }
        public float _qtdeHomem { get; set; }
        public float _qtdeCrianca { get; set; }

        public Quantidade(float qtdeHomem, float qtdeMulher, float qtdeCrianca)
        {
            _qtdeHomem = qtdeHomem;
            _qtdeMulher = qtdeMulher;
            _qtdeCrianca = qtdeCrianca;
        }

    }
}
