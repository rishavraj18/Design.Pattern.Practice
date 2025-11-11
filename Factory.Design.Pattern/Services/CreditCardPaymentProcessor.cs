namespace Factory.Design.Pattern.Services
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public string ProcessPayment(decimal amount) =>
            $"Processed {amount:C} using Credit Card.";
    }
}
