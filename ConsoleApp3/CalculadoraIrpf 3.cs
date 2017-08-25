using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class CalculadoraIrpf3
    {
        private List<AliquotaIrpf> aliquotasirpf;

   
           
            public CalculadoraIrpf3()
            {
             aliquotasirpf = new List<AliquotaIrpf>();
             aliquotasirpf.Add(new AliquotaIrpf(0, 1659.38m, 0.08m));
             aliquotasirpf.Add(new AliquotaIrpf(1659.39m, 2765.66m, 0.09m));
             aliquotasirpf.Add(new AliquotaIrpf(2765.67m, 3751.05m, 0.15m));
             aliquotasirpf.Add(new AliquotaIrpf(3751.06m, 5531.31m, 0.11m));
           
            }

        public  decimal CalcularIrpf(decimal salario)
        {           
            if (salario < 0)
            {
                throw new ArgumentException("Não é possível calcular imposto de salários negativos.", nameof(salario));
            }

            foreach (AliquotaIrpf item in aliquotasirpf)
            {
                if (item.CompreendeSalario(salario))
                {
                    return salario * item.Percentual;
                }
            }
            throw new SystemException("Aliquota não encontrada.");
        }
    }
}
