﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.SOLIDPrinciples.DIP
{
    class DbLogger : ILogger
    {
        public void LogMessage(string message)
        {
            //here saving logic on DB
        }
    }

}
