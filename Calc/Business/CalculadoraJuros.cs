using Calc.Interfaces;

namespace Calc.Business
{
    public class CalculadoraJuros
    {
        public ICalculadora Calculadora { get; set; }

        public double SomarJuros(double valor, double jurosEmPorcentagem)
        {
            var juros = CalcularValorJuros(valor, jurosEmPorcentagem);
            var response = Calculadora.Somar(valor, juros);
            return response;
        }

        private static double CalcularValorJuros(double valor, double jurosEmPorcentagem)
        {
            return valor * (jurosEmPorcentagem / 100);
        }
    }
}
