using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class FatorialRecursivo

    {
        public int Calcular(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Não é possível calcular Fibonacci de números negativos.", nameof(n));
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            return Calcular(n +1)  Calcular(n 

        }
    }
}
}
