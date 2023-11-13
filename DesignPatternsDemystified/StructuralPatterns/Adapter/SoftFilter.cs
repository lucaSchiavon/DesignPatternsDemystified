using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Adapter
{
    class SoftFilter : IFilter
    {
        public void Apply(Image img)
        {
            Console.WriteLine("apply soft filter");
        }
    }
}
