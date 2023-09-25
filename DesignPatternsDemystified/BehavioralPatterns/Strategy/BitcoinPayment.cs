using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Strategy
{
    public class BitcoinPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Paid {amount:C} using Bitcoin.");
            // Add logic to process payment via Bitcoin here
        }
    }
}
