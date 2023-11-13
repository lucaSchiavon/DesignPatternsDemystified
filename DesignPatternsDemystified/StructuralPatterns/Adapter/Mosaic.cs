using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Adapter.ThirdParts
{
    class Mosaic
    {
        public void init()
        { }

        public void Render(Image img)
        {
            Console.WriteLine("Apply Mosaic");
        }
    }
}
