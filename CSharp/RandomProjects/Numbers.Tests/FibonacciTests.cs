// <copyright file="FibonacciTests.cs" company="Adam Plaskitt">
// Copyright (c) Adam Plaskitt. All rights reserved.
// </copyright>

namespace Numbers.Tests;

/// <summary>
/// Tests for the <see cref="Fibonacci"/> class.
/// </summary>
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
