using System;
using ConsoleApp3;
using Xunit;
using FluentAssertions;

namespace Testes
{

    public class TesteFatorialRecursivo
    {
        [Fact]
        public void TestarFatorialRecursivoDe5()
        {
            ICalculaValor calcula = new CalculaFatorialRecursivo();

            int fatorialrecursivo = calcula.Calcular(5);

            fatorialrecursivo.Should().Be(120);
        }

        [Fact]
        public void TestarFatorialRecursivoDe1()
        {
            ICalculaValor calcula = new CalculaFatorialRecursivo();

            int fatorialrecursivo = calcula.Calcular(1);

            fatorialrecursivo.Should().Be(1);
        }

        [Fact]
        public void TestarFatorialRecursivoDe0()
        {
            ICalculaValor calcula = new CalculaFatorialRecursivo();

            int fatorialrecursivo = calcula.Calcular(0);

            fatorialrecursivo.Should().Be(1);
        }

        [Fact]
        public void TestarFatorialRecursivolDe3()
        {
            ICalculaValor calcula = new CalculaFatorialRecursivo();

            int fatorialrecursivo = calcula.Calcular(3);

            fatorialrecursivo.Should().Be(6);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        public void TestarFatorialRecursivoDeMenos1(int n)
        {
            ICalculaValor calcula = new CalculaFatorialRecursivo();

            Action calcular = () => calcula.Calcular(n);

            calcular.ShouldThrow<ArgumentException>().And.ParamName.Should().Be("n");
        }
    }
}
