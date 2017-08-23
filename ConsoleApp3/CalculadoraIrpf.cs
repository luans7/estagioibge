using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CalculadoraIrpf
    {
        public decimal Calcular(decimal salario)
        {

            if (salario < 0)
            {
                throw new ArgumentException("Não é possível calcular imposto de salários negativos.", nameof(salario));
            }

            if (salario <= 1903.98m)
            {
                return 0;
            }

            if (salario <= 2826.65m)
            {
                return salario * (7.5m / 100m) - 142.80m;
            }

            if (salario <= 3751.05m)
            {
                return salario * (15.0m / 100m) - 354.80m;
            }

            if (salario <= 4664.68m)
            {
                return salario * (22.5m / 100m) - 636.13m;
            }

            return salario * (27.5m / 100m) - 869.36m;
        }
    }
}
