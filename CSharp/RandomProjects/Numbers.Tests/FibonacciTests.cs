// <copyright file="FibonacciTests.cs" company="Adam Plaskitt">
// Copyright (c) Adam Plaskitt. All rights reserved.
// </copyright>

namespace Numbers.Tests;

/// <summary>
/// Tests for the <see cref="Fibonacci"/> class.
/// </summary>
public class FibonacciTests
{
    /// <summary>
    /// With a valid number the right element of the sequence is returned.
    /// </summary>
    /// <param name="number">The element index to teset.</param>
    /// <param name="answer">The actual element.</param>
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(5, 5)]
    [InlineData(11, 89)]
    public void Valid_index_returns_nth_element(int number, int answer)
    {
        int actualResult = Fibonacci.GetElementByIndex(number);

        actualResult.Should().Be(answer);
    }
}
