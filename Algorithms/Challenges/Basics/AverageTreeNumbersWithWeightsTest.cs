using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Challenges
{
    #region Enunciated

    /*
    Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
    A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C 
    tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

    Entrada
    O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

    Saída
    A sauda deve ter 1 dígito após o ponto decimal
    */

    #endregion

    public class AverageTreeNumbersWithWeightsTest
    {
        [Theory]
        [InlineData(5.0, 6.0, 7.0, 6.3)]
        [InlineData(5.0, 10.0, 10.0, 9.0)]
        [InlineData(10.0, 10.0, 5.0, 7.5)]
        public void AverageTreeNumbersWithWeights(double a, double b, double c, double expected)
        {
            var result = AverageWithWeights(a, b, c);
            result.Should().Be(expected);
        }

        private static double AverageWithWeights(in double a, in double b, in double c) =>
            Math.Round(((a * 2) + (b * 3) + (c * 5)) / (2 + 3 + 5), 1);
    }
}