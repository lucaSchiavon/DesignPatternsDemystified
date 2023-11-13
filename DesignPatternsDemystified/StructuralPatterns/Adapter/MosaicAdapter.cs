using DesignPatternsDemystified.StructuralPatterns.Adapter.ThirdParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Adapter
{
    class MosaicAdapter : IFilter
    {
        private Mosaic mosaic;
        public MosaicAdapter(Mosaic mosaic)
        {
            this.mosaic = mosaic;
        }

        public void Apply(Image img)
        {
            mosaic.init();
            mosaic.Render(img);
        }
    }
}
