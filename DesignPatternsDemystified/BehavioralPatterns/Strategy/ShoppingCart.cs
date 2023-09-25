using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Strategy
{
    public class ShoppingCart
    {
        private IPaymentStrategy paymentStrategy;

        public ShoppingCart(IPaymentStrategy strategy)
        {
            this.paymentStrategy = strategy;
        }

        public void Checkout(double totalAmount)
        {
            paymentStrategy.ProcessPayment(totalAmount);
        }

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            this.paymentStrategy = strategy;
        }
    }
}
