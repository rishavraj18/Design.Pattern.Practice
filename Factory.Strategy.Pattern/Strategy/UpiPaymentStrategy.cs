namespace Factory.Strategy.Pattern.Strategy
{
    public class UpiPaymentStrategy : IPaymentStrategy
    {
        public string PaymentType => "upi";

        public string ProcessPayment(decimal amount)
            => $"Processed {amount:C} using UPI.";
    }
}
