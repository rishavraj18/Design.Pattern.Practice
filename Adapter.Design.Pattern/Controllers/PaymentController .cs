using Adapter.Design.Pattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace Adapter.Design.Pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public PaymentController(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        [HttpPost]
        public async Task<IActionResult> MakePayment(decimal amount)
        {
            bool success = await _paymentProcessor.ProcessPayment(amount);
            if (success)
                return Ok("Payment processed successfully.");

            return BadRequest("Payment failed.");
        }
    }
}
