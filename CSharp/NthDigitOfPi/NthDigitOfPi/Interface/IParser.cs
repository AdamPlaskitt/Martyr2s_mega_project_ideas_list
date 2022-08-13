using NthDigitOfPi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigitOfPi.Interface
{
    public interface IParser
    {
        public IParser Using(IEnumerable<string>? args);

        public CommandActions ToAction();

        public double Value { get; }
    }
}
