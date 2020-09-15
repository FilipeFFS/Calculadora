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
        private static Mock<ICalculadora> _calculadoraMock = new Mock<ICalculadora>(MockBehavior.Strict);

        private CalculadoraJuros _calculadoraJuros = new CalculadoraJuros
        {
            Calculadora = _calculadoraMock.Object,
        };
        
        [TestMethod]
        public void SomarJuros()
        {
            //Arrange
            var n1 = 10;
            var n2 = 10;
            _calculadoraMock.Setup(_ => _.Somar(n1, n2)).Returns(n1+n2);

            //Act
            var response = _calculadoraJuros.SomarJuros(n1, n2);

            //Assert
            Assert.AreEqual(response, 20);
            _calculadoraMock.Verify(_ => _.Somar(n1, n2), Times.Once);
        }

        [TestMethod]
        public void SomarJuros2()
        {
            //Arrange
            var n1 = 10;
            var n2 = 10;
            var exception = new Exception("Deu ruim");
            _calculadoraMock.Setup(_ => _.Somar(n1, n2)).Throws(exception);

            //Act
            Action response = () => _calculadoraJuros.SomarJuros(n1, n2);

            //Assert
            response.Should().Throw<Exception>();
            _calculadoraMock.Verify(_ => _.Somar(n1, n2), Times.Once);
        }
    }
}

