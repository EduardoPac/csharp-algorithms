using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Challenges
{
    #region Enunciated

    /*  
    A fórmula para calcular a área de uma circunferência é: area = π . raio2. 
    Considerando para este problema que π = 3.14159:
    Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

    Entrada
    A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.
    
    Saída
    Apresentar o resultado apenas com 4 casas apos a virgula
    */

    #endregion

    public class CircleAreaTest
    {
        [Theory]
        [InlineData(2.00, 12.5664)]
        [InlineData(100.64, 31819.3103)]
        [InlineData(150.00, 70685.7750)]
        private void CalcCircleAreaBasic(double radius, double expected)
        {
            var result = CalcAreaBasic(radius);
            result.Should().Be(expected);
        }

        private static double CalcAreaBasic(in double radius) =>
            Math.Round(3.14159 * (radius * radius), 4);

        [Theory]
        [InlineData(2.00, 12.5664)]
        [InlineData(100.64, 31819.3372)] //Usando o PI de biblioteca Math do Csharp nao pode-se obter 31819.3103 pois o PI de Math usa-se mais de 5 casas
        [InlineData(150.00, 70685.8347)] //Usando o PI de biblioteca Math do Csharp nao pode-se obter 70685.7750 pois o PI de Math usa-se mais de 5 casas
        private void CalcCircleAreaMath(double radius, double expected)
        {
            var result = CalcAreaMath(radius);
            result.Should().Be(expected);
        }

        private static double CalcAreaMath(in double radius) =>
            Math.Round(Math.PI * Math.Pow(radius, 2), 4);
    }
}