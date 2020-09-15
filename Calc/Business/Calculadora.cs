using Calc.Interfaces;

namespace Calc
{
    public class Calculadora : ICalculadora
    {
        public double Somar(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        public double Subtrair(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }

        public double Multiplicar(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }

        public double Dividir(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }
    }
}

