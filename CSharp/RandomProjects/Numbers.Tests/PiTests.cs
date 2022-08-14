using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Tests;

public class PiTests
{
    [Theory]
    [InlineData(-1)]
    [InlineData(-42)]
    [InlineData(0)]
    public void GetDigitByIndex_WithInvalidNumber(int number)
    {
        Action action = () => Pi.GetDigitByIndex(number);

        action.Should().Throw<ArgumentOutOfRangeException>().WithMessage("Index must be greater than 0 (Parameter 'index')");
    }

    [Theory]
    [InlineData(1, 1)]
    [InlineData(42, 9)]
    public void Model_run_with_valid_returns_nth_digit(int number, int answer)
    {
        int actualResult = Pi.GetDigitByIndex(number);

        actualResult.Should().Be(answer);
    }
}
