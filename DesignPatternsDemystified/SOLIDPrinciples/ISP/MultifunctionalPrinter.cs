using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.SOLIDPrinciples.ISP
{
    class MultifunctionalPrinter : IPrinter, IScanner, IFax
    {
        public void Fax(Document document)
        {
        }

        public void Scan(Document document)
        {
        }

        public void Print(Document document)
        {
        }
    }

}
