using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NthDigitOfPi.Interface;

namespace NthDigitOfPi.Tests.Controller
{
    public class PiDigit
    {
        [Fact]
        public void PiDigit_is_castable_to_Command()
        {
            ICommand _ = new NthDigitOfPi.Controller.PiDigit();
        }
    }
}
