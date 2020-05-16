using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Challenges
{
    #region Enunciated

    /*
     
    Escreva um codigo que leia número de horas trabalhadas, o valor que recebe por hora e 
    calcula o salário desse funcionário.
    
    Entrada
    O arquivo de entrada contém 1 número inteiro e 1 número com duas casas decimais,
    representando quantidade de horas trabalhadas e o valor que o
    funcionário recebe por hora trabalhada, respectivamente.
    
    Saída
    O numero de horas trabalhadas multiplicado pelo valor da hora trabalhada
    
     */

    #endregion

    public class SalaryCalcBasicTest
    {
        [Theory]
        [InlineData(100, 5.50, 550)]
        [InlineData(200, 20.50, 4100)]
        [InlineData(145, 15.55, 2254.75)]
        private void SalaryCalc(int hours, double valor, double expected)
        {
            var result = SalaryCalcByHours(hours, valor);
            result.Should().Be(expected);
        }

        private static double SalaryCalcByHours(in int hours, in double valor) =>
            Math.Round(hours * valor, 2);
    }
}