using Calc.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Business
{
    public class CalculadoraJuros
    {
        public ICalculadora Calculadora { get; set; }

        public double SomarJuros(double n1, double n2)
        {
            var response = Calculadora.Somar(n1, n2);
            return response;
        }
    }
}
