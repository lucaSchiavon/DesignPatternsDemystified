using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.SOLIDPrinciples.DIP
{
    class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {
            //here saving logic on file
        }
    }

}
