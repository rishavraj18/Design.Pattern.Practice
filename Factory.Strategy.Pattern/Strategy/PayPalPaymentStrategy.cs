namespace Factory.Strategy.Pattern.Strategy
{
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public string PaymentType => "paypal";

        public string ProcessPayment(decimal amount)
            => $"Processed {amount:C} using PayPal.";
    }
}
