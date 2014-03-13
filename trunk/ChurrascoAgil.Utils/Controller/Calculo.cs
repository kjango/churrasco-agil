using ChurrascoAgil.Utils.Dao;
using ChurrascoAgil.Utils.Model;
using System.Collections.Generic;
namespace ChurrascoAgil.Utils.Controller
{
    public class Calculo
    {
        // heuristicas de carnes
        private const double HR_CARNE_HOMEM = 0.5;
        private const double HR_CARNE_MULHER = 0.4;
        private const double HR_CARNE_CRIANCA = 0.2;

        // heuristicas de bebidas
        private const double HR_BEBIDA_HOMEM = 1;
        private const double HR_BEBIDA_MULHER = 0.5;
        private const double HR_BEBIDA_CRIANCA = 0.3;

        /// <summary>
        /// Calcula o total de carnes em KG
        /// </summary>
        /// <param name="numHomens"></param>
        /// <param name="numMulheres"></param>
        /// <param name="numCriancas"></param>
        /// <returns></returns>
        public double calculaQuantidadeTotalCarne(int numHomens, int numMulheres, int numCriancas)
        {
            double resultado = HR_CARNE_HOMEM * numHomens + HR_CARNE_MULHER * numMulheres + HR_CARNE_CRIANCA * numCriancas;

            return resultado;
        }

        /// <summary>
        /// Preenche a lista de carnes com as quantidades e preços
        /// </summary>
        /// <param name="totalCarne"></param>
        /// <param name="listaCarne"></param>
        /// <returns></returns>
        public List<Alimento> calculaQuantidadeCarne(double totalCarne, List<Alimento> listaCarne)
        {
            double quantidadeUnitaria = totalCarne / listaCarne.Count;

            foreach (Alimento carne in listaCarne)
            {
                carne.Quantidade = quantidadeUnitaria;
                carne.PrecoFinal = carne.PrecoUnitario * quantidadeUnitaria;
            }

            return listaCarne;
        }

        /// <summary>
        /// Calcula os litros de bebidas necessárias
        /// </summary>
        /// <param name="numHomens"></param>
        /// <param name="numMulheres"></param>
        /// <param name="numCriancas"></param>
        /// <returns></returns>
        public double calculaLitrosTotalBebida(int numHomens, int numMulheres, int numCriancas)
        {
            double resultado = numHomens * HR_BEBIDA_HOMEM + numMulheres * HR_BEBIDA_MULHER + numCriancas * HR_BEBIDA_CRIANCA;

            return resultado;
        }

        /// <summary>
        /// Preenche a lista de bebidas com as quantidades e o preço
        /// </summary>
        /// <param name="totalBebida"></param>
        /// <param name="listaBebidas"></param>
        /// <returns></returns>
        public List<Alimento> calculaLitrosBebida(double totalBebida, List<Alimento> listaBebidas)
        {
            double litrosPorBebida = totalBebida / listaBebidas.Count;

            foreach (Alimento bebida in listaBebidas)
            {
                bebida.Quantidade = litrosPorBebida;
                bebida.PrecoFinal = bebida.PrecoUnitario * litrosPorBebida;
            }

            return listaBebidas;
        }

        /// <summary>
        /// Clacula o preço final a partir de uma lista de alimentos
        /// </summary>
        /// <param name="listaAlimento"></param>
        /// <returns></returns>
        public double calculaPrecoFinalAlimento(List<Alimento> listaAlimento)
        {
            double precoFinal = 0;

            foreach (Alimento alimento in listaAlimento) 
            {
                precoFinal += alimento.PrecoFinal;
            }

            return precoFinal;
        }
    }
}