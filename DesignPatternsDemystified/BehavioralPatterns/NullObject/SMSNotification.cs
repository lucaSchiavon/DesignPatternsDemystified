using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.NullObject
{
    public class SMSNotification : INotification
    {
        private string phoneNumber;

        public SMSNotification(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void SendNotification(string message)
        {
            // Implement sending an SMS notification logic here
            Console.WriteLine($"Sending SMS to {phoneNumber}: {message}");
        }
    }
}
