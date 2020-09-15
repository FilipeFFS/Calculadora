using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Interfaces
{
    public interface ICalculadora
    {
        double Somar(double primeiroNumero, double segundoNumero);
        double Subtrair(double primeiroNumero, double segundoNumero);
        double Multiplicar(double primeiroNumero, double segundoNumero);
        double Dividir(double primeiroNumero, double segundoNumero);
    }
}
