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

            //CalculaFibonacci calcula = new CalculaFibonacci();

            //int fibonacci = calcula.Calcular(6);
            //Console.WriteLine(fibonacci);


            //Console.ReadKey();

            // CalculaFatorialRecursivo calcula = new CalculaFatorialRecursivo();

            // int fatorialrecursivo = calcula.Calcular(6);
            // Console.WriteLine(fatorialrecursivo);


            // Console.ReadKey();

            // Fibonacci calcula = new Fibonacci();

            // int fibonacci = calcula.Calcular(6);
            //Console.WriteLine(fibonacci);


            // Console.ReadKey();

            CalculadoraIrpf2 calcula = new CalculadoraIrpf2();

            decimal salario = calcula.Calcular(10000.00m);
            Console.WriteLine(salario);


            Console.ReadKey();
        }

        
     }
   
 }

