using NthDigitOfPi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigitOfPi.Model
{
    public class CommandParser : IParser
    {
        private IEnumerable<string>? args;
        public double Value { get; private set; }

        public CommandActions ToAction()
        {
            if (args == null || !args.Any() || args.First() == "-h" || args.First() == "--help")
                return CommandActions.Help;

            if (double.TryParse(args.First(), out var value))
            {
                this.Value = value;
                return CommandActions.Calculate;
            }

            return CommandActions.Unknown;
        }

        public IParser Using(IEnumerable<string>? args)
        {
            this.args = args;
            return this;
        }
    }
}
