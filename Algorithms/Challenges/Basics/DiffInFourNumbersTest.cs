using FluentAssertions;
using Xunit;

namespace Algorithms.Challenges
{
    #region Enunciated

    /*
    Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do 
    produto de A e B pelo produto de C e D segundo a fórmula: 
    DIFERENCA = (A * B - C * D).
    
    Entrada
    O arquivo de entrada contém 4 valores inteiros.

    Saída
    Diferenca entre o produto de A,B e C,D
     */

    #endregion

    public class DiffInFourNumbersTest
    {
        [Theory]
        [InlineData(5, 6, 7, 8, -26)]
        [InlineData(0, 0, 7, 8, -56)]
        [InlineData(5, 6, -7, 8, 86)]
        private void DiffInFourNumbers(int a, int b, int c, int d, int expected)
        {
            var result = ProductDiff(a, b, c, d);
            result.Should().Be(expected);
        }

        private static double ProductDiff(in int a, in int b, in int c, in int d) => ((a * b) - (c * d));
    }
}