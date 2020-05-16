using System;
using FluentAssertions;
using Xunit;

namespace Algorithms.Challenges
{
    #region Enunciated

    /*
     
    Faça um codigo leia o salário fixo e o total de vendas efetuadas por um funcionario no mês (em dinheiro). 
    Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, 
    informar o total a receber no final do mês, com duas casas decimais.
    
    Entrada
    O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais, representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.
    
    Saída
    Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.

     */

    #endregion

    public class SalaryCalcWithBonusTest
    {
        [Theory]
        [InlineData(500.00, 1230.30, 684.54)]
        [InlineData(700.00, 0.0, 700.00)]
        [InlineData(1700.00, 1230.50, 1884.58)]
        public void SalaryCalcWithBonus(double salary, double sales, double expected)
        {
            var result = SalaryCalcBySales(salary, sales);
            result.Should().Be(expected);
        }

        private double SalaryCalcBySales(in double salary, in double sales) => 
            Math.Round((salary) + (sales * 0.15), 2);
    }
}