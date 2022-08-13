using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NthDigitOfPi.Interface;

namespace NthDigitOfPi.Tests.Controller
{
    public class PiDigitTests
    {
        [Fact]
        public void PiDigit_is_castable_to_Command()
        {
            Assert.True(typeof(ICommand).IsAssignableFrom(typeof(NthDigitOfPi.Controller.PiDigit)));
        }
    }
}
