using NthDigitOfPi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace NthDigitOfPi.Model
{
    public class Calculator : IModel
    {
        private string GetDigitError()
        {
            return "Error - The Nth digit must be a positive integer";
        }

        public string GetHelpMessage()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NAME");
            sb.AppendLine("\tPiDigit");
            sb.AppendLine();
            sb.AppendLine("\tCalculates and outputs the Nth digit of PI.");
            sb.AppendLine();
            sb.AppendLine("SYNOPSIS");
            sb.AppendLine("\tPiDigit <N>");
            sb.AppendLine("\tPiDigit [-h, --help]");
            sb.AppendLine();
            sb.AppendLine("\t<N>\t\t\tCalculates Pi to the Nth digit");
            sb.AppendLine("\t-h, --help\tDisplay help information");

            return sb.ToString().Trim();
        }

        public string GetUnknownCommandMessage()
        {
            return "Error - Unknown command, see 'PiDigit --help' for help";
        }

        public string Calculate(double n)
        {
            if (!int.TryParse(n.ToString(), out var intN))
            {
                return GetDigitError();
            }

            if (intN <= 0)
                return GetDigitError();

            return NthPi(intN-1).ToString();
        }

        private static long NthPi(int digit)
        {
            int l = (digit += 2) * 10 / 3 + 2;
            int j = 0;
            int i = 0;

            long[] x = new long[l];
            long[] r = new long[l];

            for (; j < l;)
                x[j++] = 20;

            long c, n, e, p = 0;

            for (; i < digit; ++i)
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

            return p % 10;
        }
    }
}
