using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CalculadoraInss
    {
        private List<AliquotaInss> aliquotas;

        public CalculadoraInss()
        {
            aliquotas = new List<AliquotaInss>();
            aliquotas.Add(new AliquotaInss(0, 1659.38m, 0.08m));
            aliquotas.Add(new AliquotaInss(1659.39m, 2765.66m, 0.09m));
            aliquotas.Add(new AliquotaInss(2765.67m, 5531.31m, 0.11m));
        }

        public decimal Calcular(decimal salarioInss)
        {
            if (salarioInss < 0)
            {
                throw new ArgumentException("Não é possível calcular imposto de salários negativos.", nameof(salarioInss));
            }

       
            foreach (AliquotaInss item in aliquotas)
            {
                if (item.CompreendeSalario(salarioInss))
                {
                    return salarioInss * item.PercentualInss;
                }

                if (salarioInss > 5531.31m)
                {
                    return 5331.31m * item.PercentualInss;
                }
            }
            throw new SystemException("Aliquota não encontrada.");
        }
    }
}
