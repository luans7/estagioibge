using System;
using ConsoleApp3;
using Xunit;
using FluentAssertions;

namespace Testes
{

    public class TesteCalculaFibonacci
    {
        [Fact]
        public void TestarFibonacciDe5()
        {
            ICalculaValor calcula = new CalculaFibonacci();

            int fibonacci = calcula.Calcular(5);

            fibonacci.Should().Be(8);
        }

        [Fact]
        public void TestarFibonacciDe1()
        {
            ICalculaValor calcula = new CalculaFibonacci();

            int fibonacci = calcula.Calcular(1);

            fibonacci.Should().Be(1);
        }

        [Fact]
        public void TestarFibonacciDe0()
        {
            ICalculaValor calcula = new CalculaFibonacci();

            int fibonacci = calcula.Calcular(0);

            fibonacci.Should().Be(1);
        }

        [Fact]
        public void TestarFibonacciDe3()
        {
            ICalculaValor calcula = new CalculaFibonacci();

            int fibonacci = calcula.Calcular(3);

            fibonacci.Should().Be(3);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        public void TestarFatorialDeMenos1(int n)
        {
            ICalculaValor calcula = new CalculaFibonacci();

            Action calcular = () => calcula.Calcular(n);

            calcular.ShouldThrow<ArgumentException>().And.ParamName.Should().Be("n");
        }
    }
}
