using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigitOfPi.Interface
{
    public interface IModel
    {
        public string GetHelpMessage();

        public string GetUnknownCommandMessage();

        public string Calculate(double n);
    }
}
