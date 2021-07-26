using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevinHamilton_CE03
{
    class DoNotLog:Logger
    {
        public override void LogD(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("not logging info");
            Console.ResetColor();
        }

        public override void LogW(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("not logging info");
            Console.ResetColor();
        }
    }
}
