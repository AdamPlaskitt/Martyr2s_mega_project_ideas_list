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
        public string GetHelp()
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
    }
}
