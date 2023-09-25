class Program
{
    static void Main(string[] args)
    {
        // Create a shopping cart with the default payment method (Credit Card)
        var cart = new ShoppingCart(new CreditCardPayment());

        // Make a payment
        cart.Checkout(100.00);

        // Change the payment method to PayPal
        cart.SetPaymentStrategy(new PayPalPayment());

        // Make another payment with the new payment method (PayPal)
        cart.Checkout(50.00);

        // Change the payment method to Bitcoin
        cart.SetPaymentStrategy(new BitcoinPayment());

        // Make another payment with the new payment method (Bitcoin)
        cart.Checkout(200.00);
    }
}

