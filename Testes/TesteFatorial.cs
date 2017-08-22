using System;
using ConsoleApp3;
using Xunit;
using FluentAssertions;

namespace Testes
{

    public class TesteFatorial
    {
        [Fact]
        public void FatorialiDe5()
        {
            CalculaFatorial calcula = new CalculaFatorial();

            int fatorial = calcula.Calcular(5);

            fatorial.Should().Be(120);
        }

        [Fact]
        public void TestarFatorialDe1()
        {
            CalculaFatorial calcula = new CalculaFatorial();

            int fatorial = calcula.Calcular(1);

            fatorial.Should().Be(1);
        }

        [Fact]
        public void TestarFatorialDe0()
        {
            CalculaFatorial calcula = new CalculaFatorial();

            int fatorial = calcula.Calcular(0);

            fatorial.Should().Be(1);
        }

        [Fact]
        public void TestarFatorialDe3()
        {
            CalculaFatorial calcula = new CalculaFatorial();

            int fatorial = calcula.Calcular(3);

            fatorial.Should().Be(6);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        public void TestarFatorialDeMenos1(int n)
        {
            CalculaFatorial calcula = new CalculaFatorial();

            Action calcular = () => calcula.Calcular(n);

            calcular.ShouldThrow<ArgumentException>().And.ParamName.Should().Be("n");
        }
    }
}
