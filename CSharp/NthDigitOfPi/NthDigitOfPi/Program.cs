using NthDigitOfPi.Controller;
using NthDigitOfPi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigitOfPi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICommand command = new PiDigit();
        }
    }
}
