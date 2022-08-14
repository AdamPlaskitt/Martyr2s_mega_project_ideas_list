using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class Fibonacci
    {
        /// <summary>
        /// Calculates the Nth element in the Fibonacci sequence.
        /// </summary>
        /// <param name="number">The elemt to get.</param>
        /// <returns>The Nth element of the Fibonacci sequence.</returns>
        public static int FibonacciElement(int number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return 1;

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
}
