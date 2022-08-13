using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Sequence
{
    public class Program
    {
        public static void Main() { }


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
