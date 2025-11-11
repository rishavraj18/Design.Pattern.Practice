namespace Factory.Strategy.Pattern.Strategy
{
    public interface IPaymentStrategy
    {
        string PaymentType { get; } // PaymentType will help the factory identify which strategy to pick.
        string ProcessPayment(decimal amount);
    }
}
