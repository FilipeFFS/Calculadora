using Calc.Business;
using Calc.Interfaces;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Calc.Unit.Test
{
    [TestClass]
    public class CalculadoraJurosUnitTest
    {
        private static Mock<ICalculadora> _calculadoraMock;

        private CalculadoraJuros _calculadoraJuros;

        public CalculadoraJurosUnitTest()
        {
            _calculadoraMock = new Mock<ICalculadora>(MockBehavior.Strict);
            _calculadoraJuros = new CalculadoraJuros
            {
                Calculadora = _calculadoraMock.Object
            };
        }

        [TestMethod]
        public void SomarJuros()
        {
            //Arrange
            var valor = 10;
            var jurosEmPorcentagem = 10;
            var jurosCalculado = 1;
            var valorTotal = valor + jurosCalculado;

            //Setup
            _calculadoraMock.Setup(_ => _.Somar(valor, jurosCalculado)).Returns(11);

            //Act
            var response = _calculadoraJuros.SomarJuros(valor, jurosEmPorcentagem);

            //Assert
            Assert.AreEqual(response, valorTotal);
            response.Should().BeOfType(typeof(double));
            _calculadoraMock.Verify(_ => _.Somar(valor, jurosCalculado), Times.Once);
        }

        [TestMethod]
        public void SomarJuros2_Exception()
        {
            //Arrange
            var valor = 10;
            var jurosEmPorcentagem = 10;
            var jurosCalculado = 1;
            var valorTotal = valor + jurosCalculado;

            var exception = new Exception("Deu ruim");
            _calculadoraMock.Setup(_ => _.Somar(valor, jurosCalculado)).Throws(exception);

            //Act
            Action response = () => _calculadoraJuros.SomarJuros(valor, jurosEmPorcentagem);

            //Assert
            response.Should().Throw<Exception>();
            _calculadoraMock.Verify(_ => _.Somar(valor, jurosCalculado), Times.Once);
        }
    }
}

