namespace Adapter.Design.Pattern.Services
{
    public class StripeService
    {
        public async Task<string> MakePaymentAsync(decimal totalAmount)
        {
            // Simulate Stripe logic
            await Task.Delay(500);
            return "Payment Successful";
        }
    }
}
