using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.NullObject
{
    // Null Notification implementation
    public class NullNotification : INotification
    {
        public void SendNotification(string message)
        {
            // Do nothing (no-op) when using the Null Notification
        }
    }
}
