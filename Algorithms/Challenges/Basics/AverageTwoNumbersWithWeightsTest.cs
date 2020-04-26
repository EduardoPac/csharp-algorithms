using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Challenges
{
    #region Enunciated

    /*
    Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. 
    A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 
    (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, 
    sempre com uma casa decimal.
    
    Entrada
    O arquivo de entrada contém 2 valores com uma casa decimal cada um.

    Saída
    Calcule e o resultado deve ter 5 dígitos após o ponto decimal.
    Utilize variáveis de dupla precisão (double) e como todos os problemas
    */

    #endregion

    public class AverageTwoNumbersWithWeightsTest
    {
        [Theory]
        [InlineData(5.0, 7.1, 6.43182)]
        [InlineData(0.0, 7.1, 4.84091)]
        [InlineData(10.0, 10.0, 10.00000)]
        private void AverageTwoNumbers(double a, double b, double expected)
        {
            var result = AverageWithWeights(a, b);
            result.Should().Be(expected);
        }

        private static double AverageWithWeights(in double a, in double b) =>
            Math.Round(((a * 3.5) + (b * 7.5)) / (3.5 + 7.5), 5);
    }
}