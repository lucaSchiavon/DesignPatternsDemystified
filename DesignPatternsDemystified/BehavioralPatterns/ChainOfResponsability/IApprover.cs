using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.ChainOfResponsability
{
    //handler interface
    public interface IApprover
    {
        string Name { get; }
        decimal ApprovalLimit { get; }
        void ProcessRequest(PurchaseRequest request);
    }
}
