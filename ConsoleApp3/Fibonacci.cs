using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Fibonacci : ICalculaValor
    {
        public int Calcular(int n)
        {

            if (n < 0)
            {
                throw new ArgumentException("Não é possível calcular fatorial de números negativos.", nameof(n));
            }

            int fibonacci = 1;

            for (int i = 1; i <= n; i++)
            {
                fibonacci = (i-1) + (i-2);
            }

            return fibonacci;
        }
    }
}
