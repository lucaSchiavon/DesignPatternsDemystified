using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.StructuralPatterns.Bridge
{
    public class AdvanceRemoteControl : RemoteControl
    {

        public AdvanceRemoteControl(Device device)
            : base(device)
        {
            this.device = device;
        }

        public void SetChannel(int number)
        {
            device.SetChannel(number);
        }
    }

}
