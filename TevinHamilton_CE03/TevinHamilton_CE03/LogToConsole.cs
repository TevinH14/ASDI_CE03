using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevinHamilton_CE03
{
    class LogToConsole:Logger
    {
        public override void LogD(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Line number {_lineNumber} DEBUG {s} ");
            _lineNumber++;
            Console.ResetColor();
        }

        public override void LogW(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Line number {_lineNumber} WARNING {s} ");
            _lineNumber++;
            Console.ResetColor();
        }
    }
}
