using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CalculadoraIrpf2 
    {
        private List<Aliquota> aliquotas;

        public CalculadoraIrpf2()
        {
            aliquotas = new List<Aliquota>();
            aliquotas.Add(new Aliquota(0, 1903.98m, 0, 0));
            aliquotas.Add(new Aliquota(1903.99m, 2826.65m, 0.075m, 142.80m));
            aliquotas.Add(new Aliquota(2826.65m, 3751.05m, 0.15m, 354.80m));
            aliquotas.Add(new Aliquota(3751.06m, 4664.68m, 0.225m, 636.13m));
            aliquotas.Add(new Aliquota(4664.69m, null, 0.275m, 869.36m));
        }
        

        public decimal Calcular(decimal salario)
        {           
            if (salario < 0)
            {
                throw new ArgumentException("Não é possível calcular imposto de salários negativos.", nameof(salario));
            }

            foreach (Aliquota item in aliquotas)
            {
                if (item.CompreendeSalario(salario))
                {
                    return salario * item.Percentual - item.ParcelaDeduzir;
                }
            }
            throw new SystemException("Aliquota não encontrada.");
        }
    }
}
