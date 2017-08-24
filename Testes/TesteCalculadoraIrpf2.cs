using System;
using ConsoleApp3;
using Xunit;
using FluentAssertions;

namespace Testes
{
    public class TesteCalculadoraIrpf2
    {
        [Fact]
        public void TestaSalarioDe1000()
        {
            CalculadoraIrpf2 calcula = new CalculadoraIrpf2();

            decimal salario = calcula.Calcular(1000m);

            salario.Should().Be(0m);
        }

        [Fact]
        public void TestaSalarioD19000()
        {
            CalculadoraIrpf2 calcula = new CalculadoraIrpf2();

            decimal salario = calcula.Calcular(1900m);

            salario.Should().Be(2.000m);
        }

        [Fact]
        public void TestaSalarioDe4000()
        {
            CalculadoraIrpf2 calcula = new CalculadoraIrpf2();

            decimal salario = calcula.Calcular(5m);

            salario.Should().Be(2.000m);
        }

        [Fact]
        public void TestaSalarioDe5000()
        {
            CalculadoraIrpf2 calcula = new CalculadoraIrpf2();

            decimal salario = calcula.Calcular(5m);

            salario.Should().Be(2.000m);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-2)]
        public void TestarFatorialDeMenos1(int n)
        {
            CalculadoraIrpf2 calcula = new CalculadoraIrpf2();

            Action calcular = () => calcula.Calcular(n);

            calcular.ShouldThrow<ArgumentException>().And.ParamName.Should().Be("salario");
        }
    }
}
