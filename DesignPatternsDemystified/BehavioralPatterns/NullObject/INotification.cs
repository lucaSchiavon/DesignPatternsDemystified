using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.NullObject
{
    // Define the INotification interface
    public interface INotification
    {
        void SendNotification(string message);
    }
}
