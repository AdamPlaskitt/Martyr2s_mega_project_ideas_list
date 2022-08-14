// <copyright file="Pi.cs" company="Adam Plaskitt">
// Copyright (c) Adam Plaskitt. All rights reserved.
// </copyright>

namespace Numbers;

/// <summary>
/// Represents actions around PI.
/// </summary>
public class Pi
{
    /// <summary>
    /// Gets the Nth digit of PI.
    /// </summary>
    /// <param name="index">The Nth digit to get.</param>
    /// <returns>The Nth digit of PI.</returns>
    /// <exception cref="ArgumentOutOfRangeException">The <paramref name="index"/> must be greater than 0.</exception>
    public static int GetDigitByIndex(int index)
    {
        if (index <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must be greater than 0");
        }

        int position = index - 1;

        int l = ((position += 2) * 10 / 3) + 2;
        int j = 0;
        int i = 0;

        long[] x = new long[l];
        long[] r = new long[l];

        for (; j < l;)
        {
            x[j++] = 20;
        }

        long c, n, e, p = 0;

        for (; i < position; ++i)
        {
            for (j = 0, c = 0; j < l; c = (x[j++] / e) * n)
            {
                n = l - j - 1;
                e = (n * 2) + 1;

                r[j] = (x[j] += c) % e;
            }

            p = x[--l] / 10;

            r[l] = x[l++] % 10;

            for (j = 0; j < l;)
            {
                x[j] = r[j++] * 10;
            }
        }

        return (int)(p % 10);
    }
}
