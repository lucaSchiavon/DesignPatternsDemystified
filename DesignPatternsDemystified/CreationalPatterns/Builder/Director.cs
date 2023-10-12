using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.Builder
{
    // Director
    class ComputerDirector
    {
        private IComputerBuilder builder;

        public ComputerDirector(IComputerBuilder builder)
        {
            this.builder = builder;
        }

        public Computer ConstructComputer()
        {
            builder.SetCPU();
            builder.SetRAM();
            builder.SetStorage();
            builder.SetGraphicsCard();
            return builder.Build();
        }
    }
}
