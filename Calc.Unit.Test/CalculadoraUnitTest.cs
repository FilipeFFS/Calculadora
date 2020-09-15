using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calc.Unit.Test
{
    [TestClass]
    public class CalculadoraUnitTest
    {
        private Calculadora _calculadora;
        
        [TestMethod]
        public void Somar()
        {
            //Arrange
            _calculadora = new Calculadora();
            var n1 = 10;
            var n2 = 10;

            //Act
            var resposta = _calculadora.Somar(n1, n2);

            //Assert
            Assert.AreEqual(resposta, 20);
        }

        [TestMethod]
        public void Subtrair()
        {
            //Arrange
            _calculadora = new Calculadora();
            var n1 = 20;
            var n2 = 10;

            //Act
            var resposta = _calculadora.Subtrair(n1, n2);

            //Assert
            Assert.AreEqual(resposta, 10);
        }

        [TestMethod]
        public void Dividir()
        {
            //Arrange
            _calculadora = new Calculadora();
            var n1 = 20;
            var n2 = 10;

            //Act
            var resposta = _calculadora.Dividir(n1, n2);

            //Assert
            Assert.AreEqual(resposta, 2);
        }

        [TestMethod]
        public void Multiplicacao()
        {
            //Arrange
            _calculadora = new Calculadora();
            var n1 = 20;
            var n2 = 10;

            //Act
            var resposta = _calculadora.Multiplicar(n1, n2);

            //Assert
            Assert.AreEqual(resposta, 200);
        }
    }
}
