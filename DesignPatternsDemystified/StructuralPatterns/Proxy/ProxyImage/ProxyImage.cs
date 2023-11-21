using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Proxy.ProxyImage
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private string filename;

        public ProxyImage(string filename)
        {
            this.filename = filename;
        }

        public void Display()
        {
            // Create the real image only when it's actually needed
            if (realImage == null)
            {
                realImage = new RealImage(filename);
            }

            // Delegate the display to the real image
            realImage.Display();
        }
    }

}
