using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Tests
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(5, 5)]
        [InlineData(11, 89)]
        public void Model_run_with_valid_returns_nth_digit(int number, int answer)
        {
            int actualResult = Fibonacci.GetElementByIndex(number);

            actualResult.Should().Be(answer);
        }
    }
}
