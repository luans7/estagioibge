using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Aliquota
    {
        public decimal SalarioInicial { get; private set; }

        public decimal? SalarioFinal { get; private set; }

        public decimal Percentual { get; private set; }

        public decimal ParcelaDeduzir { get; private set; }

        public Aliquota (decimal salarioInicial, decimal? salarioFinal, decimal percentual, decimal parcelaDeduzir)
        {
            this.SalarioInicial = salarioInicial;
            this.SalarioFinal = salarioFinal;
            this.Percentual = percentual;
            this.ParcelaDeduzir = parcelaDeduzir;
        }

        public bool CompreendeSalario(decimal salario)
        {
            if (SalarioFinal.HasValue)
                return SalarioInicial <= salario && SalarioFinal >= salario;
            else
                return SalarioInicial >salario;
        }
    }
}
