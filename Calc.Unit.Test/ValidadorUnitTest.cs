using Calc.Business;
using Calc.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Calc.Unit.Test
{
    [TestClass]
    public class ValidadorUnitTest
    {
        private Validador _validador;

        public ValidadorUnitTest()
        {
            _validador = new Validador();
        }

        [TestMethod]
        public void MaiorQueUm_True()
        {
            //Arrange
            int valor = 10;

            //Act
            var response = _validador.MaiorQueUm(valor);

            //Assert
            Assert.AreEqual(response, true);
        }

        [TestMethod]
        public void MaiorQueUm_False()
        {
            //Arrange
            int valor = 0;

            //Act
            var response = _validador.MaiorQueUm(valor);

            //Assert
            Assert.AreEqual(response, false);
        }
    }
}
