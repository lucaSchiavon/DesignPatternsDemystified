using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.SOLIDPrinciples.DIP
{
    class ExceptionLogger
    {
        private ILogger logger;
        public ExceptionLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogException(Exception ex)
        {
            logger.LogMessage(ex.Message);
        }
    }

}
