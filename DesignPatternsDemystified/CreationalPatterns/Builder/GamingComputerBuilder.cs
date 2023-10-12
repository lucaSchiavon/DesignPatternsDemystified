using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns.Builder
{
    // Concrete Builder
    class GamingComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();

        public void SetCPU()
        {
            computer.CPU = "Intel Core i9";
        }

        public void SetRAM()
        {
            computer.RAM = "32GB DDR4";
        }

        public void SetStorage()
        {
            computer.Storage = "1TB SSD";
        }

        public void SetGraphicsCard()
        {
            computer.GraphicsCard = "NVIDIA GeForce RTX 3080";
        }

        public Computer Build()
        {
            return computer;
        }
    }
}
