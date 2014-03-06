using ChurrascoAgil.Utils.Dao;
using ChurrascoAgil.Utils.Model;
using System.Collections.Generic;
namespace ChurrascoAgil.Utils.Controller
{
    public class Calculo
    {
        // heuristicas
        private double qh = 0.5;
        private double qm = 0.4;
        private double qc = 0.2;

        public double calculaCarnivoroTotal(int numHomens, int numMulheres, int numCriancas)
        {
            double resultado = qh * numHomens + qm * numMulheres + qc * numCriancas;

            return resultado;
        }

        public List<Alimento> calculaCarnivoroParcial(double qTotCarne, List<Alimento> listao)
        {
            List<Alimento> goku = new List<Alimento>();
            double qAux = qTotCarne / listao.Count;

            foreach (Alimento alCapone in listao)
            {
                alCapone.Quantidade = qAux;
            }
            return goku;
        }

    }
}