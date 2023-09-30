using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.NullObject
{
    // Customer class
    public class Customer
    {
        public string Name { get; }
        private INotification notificationPreference;

        public Customer(string name, INotification notificationPreference = null)
        {
            Name = name;
            // Use the Null Notification if no preference is specified
            this.notificationPreference = notificationPreference ?? new NullNotification();
        }

        public void Notify(string message)
        {
            notificationPreference.SendNotification(message);
        }
    }
}
