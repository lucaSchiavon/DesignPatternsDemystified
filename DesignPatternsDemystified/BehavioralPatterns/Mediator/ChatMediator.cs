using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Mediator
{
    // Concrete Mediator
    public class ChatMediator : IChatMediator
    {
        private List<IUser> users = new List<IUser>();

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (var user in users)
            {
                // Don't send the message back to the sender
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }
}
