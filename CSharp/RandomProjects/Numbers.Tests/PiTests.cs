// <copyright file="PiTests.cs" company="Adam Plaskitt">
// Copyright (c) Adam Plaskitt. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Tests;

/// <summary>
/// Tests for the <see cref="Pi"/> class.
/// </summary>
public class PiTests
{
    /// <summary>
    /// Getting a digit of PI with an invlaid index throws an error.
    /// </summary>
    /// <param name="number">The index to use.</param>
    [Theory]
    [InlineData(-1)]
    [InlineData(-42)]
    [InlineData(0)]
    public void GetDigitByIndex_WithInvalidNumber(int number)
    {
        Action action = () => Pi.GetDigitByIndex(number);

        action.Should().Throw<ArgumentOutOfRangeException>().WithMessage("Index must be greater than 0 (Parameter 'index')");
    }

    /// <summary>
    /// Getting a digit of PI with a valid index, returns corrent digit of PI.
    /// </summary>
    /// <param name="number">The index to test.</param>
    /// <param name="answer">The correct digit to be returned.</param>
    [Theory]
    [InlineData(1, 1)]
    [InlineData(42, 9)]
    public void Valid_index_returns_nth_digit(int number, int answer)
    {
        int actualResult = Pi.GetDigitByIndex(number);

        actualResult.Should().Be(answer);
    }
}
