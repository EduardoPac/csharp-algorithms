using FluentAssertions;
using Xunit;

namespace Algorithms.Challenges
{
    #region Enunciated

    /*
    Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores  
        
    Entrada
    O arquivo de entrada contém 2 valores inteiros.

    Saída
    A multiplicacao desses dois valores
    */

    #endregion

    public class MultipleTwoNumbersTest
    {
        [Theory]
        [InlineData(3, 9, 27)]
        [InlineData(-30, 10, -300)]
        [InlineData(0, 9, 0)]
        private void MultipleTwoNumbers(int a, int b, int expected)
        {
            var result = ProdTwoNumbers(a, b);
            result.Should().Be(expected);
        }

        private static int ProdTwoNumbers(in int a, in int b) => a * b;
    }
}