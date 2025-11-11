using Factory.Design.Pattern.Factory;
using Microsoft.AspNetCore.Mvc;

namespace Factory.Design.Pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        [HttpPost]
        public IActionResult ProcessPayment(string type, decimal amount)
        {
            PaymentFactory factory = type.ToLower() switch
            {
                "creditcard" => new CreditCardPaymentFactory(),
                "paypal" => new PayPalPaymentFactory(),
                _ => throw new ArgumentException("Invalid payment type")
            };

            var processor = factory.CreatePaymentProcessor();
            var result = processor.ProcessPayment(amount);
            return Ok(result);
        }
    }
}
