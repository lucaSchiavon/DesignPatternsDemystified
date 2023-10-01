using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Mediator
{
    // Mediator interface
    public interface IChatMediator
    {
        void SendMessage(string message, IUser user);
        void AddUser(IUser user);
    }
}
