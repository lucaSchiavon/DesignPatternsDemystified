using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.ChainOfResponsability
{
    // PurchaseRequest class
    public class PurchaseRequest
    {
        public string Item { get; }
        public decimal Amount { get; }

        public PurchaseRequest(string item, decimal amount)
        {
            Item = item;
            Amount = amount;
        }
    }
}
