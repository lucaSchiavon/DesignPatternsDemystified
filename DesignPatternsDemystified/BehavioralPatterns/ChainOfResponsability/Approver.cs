using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.ChainOfResponsability
{
    // ConcreteHandler class
    public class Approver : IApprover
    {
        public string Name { get; }
        public decimal ApprovalLimit { get; }
        private IApprover successor;

        public Approver(string name, decimal approvalLimit, IApprover successor = null)
        {
            Name = name;
            ApprovalLimit = approvalLimit;
            this.successor = successor;
        }

        public void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount >= ApprovalLimit)
            {
                Console.WriteLine($"{Name} approved the purchase of {request.Item} for {request.Amount:C}");
            }
            else if (successor != null)
            {
                Console.WriteLine($"{Name} cannot approve. Escalating to {successor.Name}.");
                successor.ProcessRequest(request);

            }
            else
            {
                Console.WriteLine($"None of the approvers can handle the request for {request.Item}.");
            }
        }
    }
}
