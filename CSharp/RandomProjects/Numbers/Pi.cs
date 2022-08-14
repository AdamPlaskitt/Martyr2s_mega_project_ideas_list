using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class Pi
    {
        public static int GetDigitByIndex(int index)
        {
            if (index <= 0) throw new ArgumentOutOfRangeException(nameof(index), "Index must be greater than 0");

            int position = index - 1;

            int l = (position += 2) * 10 / 3 + 2;
            int j = 0;
            int i = 0;

            long[] x = new long[l];
            long[] r = new long[l];

            for (; j < l;)
                x[j++] = 20;

            long c, n, e, p = 0;

            for (; i < position; ++i)
            {
                for (j = 0, c = 0; j < l; c = (x[j++] / e) * n)
                {
                    n = l - j - 1;
                    e = n * 2 + 1;

                    r[j] = (x[j] += c) % e;
                }

                p = x[--l] / 10;

                r[l] = x[l++] % 10;

                for (j = 0; j < l;)
                    x[j] = r[j++] * 10;
            }

            return (int)(p % 10);
        }
    }
}
