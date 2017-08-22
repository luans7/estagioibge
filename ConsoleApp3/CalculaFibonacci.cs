using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CalculaFibonacci : ICalculaValor
    {
        public int Calcular(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Não é possível calcular Fibonacci de números negativos.", nameof(n));
            }

            if (n == 1 || n == 0)
            {
                return 1;
            }

            return Calcular(n - 1) + Calcular(n - 2);

        }
    }
}