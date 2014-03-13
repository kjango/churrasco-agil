using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChurrascoAgil.Utils.Controller;
using ChurrascoAgil.Utils.Model;

namespace UnitTestChurrascoAgil
{
    [TestClass]
    public class TestCalcular
    {
        /// <summary>
        /// Teste de calculo total de carnes
        /// </summary>
        [TestMethod]
        public void testaCalculaCarneTotal()
        {
            Calculo calculo = new Calculo();

            Assert.AreEqual(5,5,
                calculo.calculaQuantidadeTotalCarne(5, 7, 1));
        }

        /// <summary>
        /// Teste de calculo total de bebidas
        /// </summary>
        [TestMethod]
        public void testaCalculaBebidaTotal()
        {
            Calculo calculo = new Calculo();

            Assert.AreEqual(8,8,
                calculo.calculaLitrosTotalBebida(5, 7, 1));
        }

        /// <summary>
        /// Teste de cálculo de preço total
        /// </summary>
        [TestMethod]
        public void testaCalculoPrecoFinal()
        {
            Calculo calculo = new Calculo();
            System.Collections.Generic.List<Alimento> listaTeste = new System.Collections.Generic.List<Alimento>();

            // Preenche a lista hard coded para testar
            Alimento a1 = new Alimento();
            a1.PrecoFinal = 10;

            listaTeste.Add(a1);

            Alimento a2 = new Alimento();
            a2.PrecoFinal = 24.2;

            listaTeste.Add(a2);

            Assert.AreEqual(34,2, calculo.calculaPrecoFinalAlimento(listaTeste));
        }
    }
}
