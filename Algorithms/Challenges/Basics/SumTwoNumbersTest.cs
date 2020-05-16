using FluentAssertions;
using Xunit;

namespace Algorithms.Challenges
{
    #region Enunciated

    /*
    Leia 2 valores inteiros e armazene-os nas variáveis A e B. Efetue a soma de A e B atribuindo o seu 
    resultado a outra variável. 
    
    Entrada
    - A entrada contém 2 valores inteiros.
    
    Saída
    - Soma dos dois numeros inteiros
    */

    #endregion

    public class SumTwoNumbersTest
    {
        [Theory]
        [InlineData(10, 9, 19)]
        [InlineData(-10, 4, -6)]
        [InlineData(15, -7, 8)]
        private void SumTwoNumbers(int a, int b, int expected)
        {
            var result = Sum(a, b);
            result.Should().Be(expected);
        }

        private static int Sum(in int a, in int b) => a + b;
    }
}