using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Challenges
{
    /*
    Enunciado     
    - A fórmula para calcular a área de uma circunferência é: area = π . raio2. 
    - Considerando para este problema que π = 3.14159:
    - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

    Entrada
    - A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.
    
    Saída
    - Apresentar o resultado apenas com 4 casas apos a virgula
    */
    
    public class CircleAreaTest
    {
        [Theory]
        [InlineData(2.00, 12.5664)]
        [InlineData(100.64, 31819.3103)]
        [InlineData(150.00, 70685.7750)]
        private void CalcCircleAreaBasic(double raid,  double expected)
        {
            var result = CalcAreaBasic(raid);
            result.Should().Be(expected);
        }

        private static double CalcAreaBasic(double raid) => 
            Math.Round(3.14159 * (raid * raid), 4);

        [Theory]
        [InlineData(2.00, 12.5664)]
        [InlineData(100.64, 31819.3372)] //Usando o PI de biblioteca Math do Csharp nao pode-se obter 31819.3103 pois o PI de Math usa-se mais de 5 casas
        [InlineData(150.00, 70685.8347)] //Usando o PI de biblioteca Math do Csharp nao pode-se obter 70685.7750 pois o PI de Math usa-se mais de 5 casas
        private void CalcCircleAreaMath(double raid, double expected)
        {
            var result = CalcAreaMath(raid);
            result.Should().Be(expected);
        }

        private static double CalcAreaMath(double raid) => 
            Math.Round(Math.PI * Math.Pow(raid, 2), 4);
    }
}