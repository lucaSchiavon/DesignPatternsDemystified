using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal.");
            // Add logic to process payment via PayPal here
        }
    }

}
