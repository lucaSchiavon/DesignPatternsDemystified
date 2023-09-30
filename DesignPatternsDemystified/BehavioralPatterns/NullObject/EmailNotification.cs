using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.NullObject
{
    // Concrete notification implementations
    public class EmailNotification : INotification
    {
        private string email;

        public EmailNotification(string email)
        {
            this.email = email;
        }

        public void SendNotification(string message)
        {
            // Implement sending an email notification logic here
            Console.WriteLine($"Sending email to {email}: {message}");
        }
    }
}
