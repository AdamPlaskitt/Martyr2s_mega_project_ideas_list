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
        public CommandActions ToAction()
        {
            return CommandActions.Help;
        }

        public IParser Using(IEnumerable<string>? args)
        {
            return this;
        }
    }
}
