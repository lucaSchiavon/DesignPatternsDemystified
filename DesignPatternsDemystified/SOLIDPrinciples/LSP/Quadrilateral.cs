using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.SOLIDPrinciples.LSP
{
    public class Quadrilateral
    {

        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public int Area
        {
            get
            {
                return Height * Width;
            }
        }
    }

}
