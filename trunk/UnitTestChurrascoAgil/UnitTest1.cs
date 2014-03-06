using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChurrascoAgil.Utils.Controller;

namespace UnitTestChurrascoAgil
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void testaCalculaCarnivoroTotal()
        {
            Calculo calculo = new Calculo();

            Assert.AreEqual(5.5, calculo.calculaCarnivoroTotal(5, 7, 1));
        }
    }
}
