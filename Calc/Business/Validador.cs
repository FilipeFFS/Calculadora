using Calc.Interfaces;

namespace Calc.Business
{
    public class Validador : IValidador
    {
        public bool MaiorQueUm(double valor)
        {
            return (valor > 1) ? true : false;
        }
    }
}
