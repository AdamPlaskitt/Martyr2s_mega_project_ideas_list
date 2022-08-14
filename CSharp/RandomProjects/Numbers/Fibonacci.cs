// <copyright file="Fibonacci.cs" company="Adam Plaskitt">
// Copyright (c) Adam Plaskitt. All rights reserved.
// </copyright>

namespace Numbers;

/// <summary>
/// Represents actions around the Fibonacci sequence.
/// </summary>
public class Fibonacci
{
    /// <summary>
    /// Calculates the Nth element in the Fibonacci sequence.
    /// </summary>
    /// <param name="number">The elemt to get.</param>
    /// <returns>The Nth element of the Fibonacci sequence.</returns>
    public static int GetElementByIndex(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        else if (number == 1)
        {
            return 1;
        }

        int oldElement = 0;
        int newElement = 1;

        for (int i = 1; i < number; i++)
        {
            int tmp = oldElement;
            oldElement = newElement;
            newElement = tmp + oldElement;
        }

        return newElement;
    }
}
