using NthDigitOfPi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigitOfPi.Tests.Model
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(-42)]
        [InlineData(0)]
        [InlineData(0.42)]
        [InlineData(42.42)]
        public void Model_run_with_invalid_returns_error(double number)
        {
            var model = new Calculator();

            model.Calculate(number).Should().Be("Error - The Nth digit must be a positive integer");
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(42, 9)]
        public void Model_run_with_valid_returns_nth_digit(double number, int answer)
        {
            var model = new Calculator();

            model.Calculate(number).Should().Be(answer.ToString());
        }
    }
}
