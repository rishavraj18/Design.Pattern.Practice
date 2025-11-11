namespace Factory.Strategy.Pattern.Strategy
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public string PaymentType => "creditcard";

        public string ProcessPayment(decimal amount)
            => $"Processed {amount:C} using Credit Card.";
    }
}
