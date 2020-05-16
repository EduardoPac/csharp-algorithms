using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Challenges
{
    #region Enunciated

    /*
     Neste problema, deve-se ler o o número de peças 1, o valor unitário de cada peça 1,
     o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. 
     Após, calcule e mostre o valor a ser pago.
     */

    #endregion

    public class CalcSaleByCountTest
    {
        [Theory]
        [InlineData(1, 5.30, 2, 5.10, 15.50)]
        [InlineData(2, 15.30, 4, 5.20, 51.40)]
        [InlineData(1, 15.10, 1, 15.10, 30.20)]
        public void CalcSaleByCount(int countA, double valueA, int countB, double valueB, double expected)
        {
            var result = CalcSaleTwoProducts(countA, valueA, countB, valueB);
            result.Should().Be(expected);
        }

        private static double CalcSaleTwoProducts(in int countA, in double valueA, in int countB, in double valueB) => 
            Math.Round((countA * valueA) + (countB * valueB), 2);
    }
}