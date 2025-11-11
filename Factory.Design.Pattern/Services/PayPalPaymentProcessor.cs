namespace Factory.Design.Pattern.Services
{
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public string ProcessPayment(decimal amount) =>
            $"Processed {amount:C} using PayPal.";
    }
}
