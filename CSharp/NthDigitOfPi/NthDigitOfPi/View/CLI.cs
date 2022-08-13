using NthDigitOfPi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigitOfPi.View
{
    public class CLI : IView
    {
        public void Render(string text)
        {
            Console.WriteLine(text);
        }
    }
}
