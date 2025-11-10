using Adapter.Design.Pattern.Services;

namespace Adapter.Design.Pattern.Adapter
{
    public class StripePaymentAdapter : IPaymentProcessor
    {
        private readonly StripeService _stripeService;

        public StripePaymentAdapter(StripeService stripeService)
        {
            _stripeService = stripeService;
        }

        public async Task<bool> ProcessPayment(decimal amount)
        {
            var result = await _stripeService.MakePaymentAsync(amount);
            return result.Contains("Successful");
        }
    }

    // We can later replace the adapter with another one (e.g., PayPalPaymentAdapter) without changing the controller logic.

    //public class PayPalPaymentAdapter : IPaymentProcessor
    //{
    //    private readonly PayPalService _payPalService;

    //    public PayPalPaymentAdapter(PayPalService payPalService)
    //    {
    //        _payPalService = payPalService;
    //    }

    //    public async Task<bool> ProcessPayment(decimal amount)
    //    {
    //        var response = await _payPalService.ExecutePayment(amount);
    //        return response.IsApproved;
    //    }
    //}
}
