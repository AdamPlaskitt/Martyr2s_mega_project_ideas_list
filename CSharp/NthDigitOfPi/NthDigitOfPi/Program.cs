using NthDigitOfPi.Controller;
using NthDigitOfPi.Interface;
using NthDigitOfPi.Model;
using NthDigitOfPi.View;
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
            IParser commandParser = new CommandParser();
            IView view = new CLI();
            ICommand command = new PiDigit(commandParser, null, view);
        }
    }
}
