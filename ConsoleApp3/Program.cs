using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculaFatorial calcula = new CalculaFatorial();

            //int fatorial = calcula.Calcular(5);
            //Console.WriteLine(fatorial);
                

            //Console.ReadKey();

            CalculaFibonacci calcula = new CalculaFibonacci();

            int fibonacci = calcula.Calcular(5);
            Console.WriteLine(fibonacci);


            Console.ReadKey();
        }      
    }
}

