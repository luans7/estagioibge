using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class AliquotaInss
    {
        public decimal SalarioInicialInss { get; private set; }

        public decimal? SalarioFinalInss { get; private set; }

        public decimal PercentualInss { get; private set; }      

        public AliquotaInss(decimal salarioInicialInss, decimal? salarioFinalInss, decimal percentualInss)
        {
            this.SalarioInicialInss = salarioInicialInss;
            this.SalarioFinalInss = salarioFinalInss;
            this.PercentualInss = percentualInss;          
        }

        public bool CompreendeSalario(decimal salarioInss)
        {
            if (SalarioFinalInss.HasValue)
                return SalarioInicialInss <= salarioInss && SalarioFinalInss >= salarioInss;
            else
                return SalarioInicialInss <= salarioInss;
        }
    }
}
