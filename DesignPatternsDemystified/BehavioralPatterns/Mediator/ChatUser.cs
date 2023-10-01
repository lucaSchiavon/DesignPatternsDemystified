using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Mediator
{
    // Concrete Colleague
    public class ChatUser : IUser
    {
        private readonly IChatMediator mediator;
        private string name;

        public ChatUser(IChatMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{name} sends message: {message}");
            mediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"{name} receives message: {message}");
        }
    }

}
