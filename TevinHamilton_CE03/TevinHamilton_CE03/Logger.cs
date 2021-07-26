using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevinHamilton_CE03
{
    abstract class Logger:ILog
    {
        protected static int _lineNumber;

        public Logger()
        {

        }
        public abstract void LogD(string s);
        public abstract void LogW(string s);
        
    }
}
