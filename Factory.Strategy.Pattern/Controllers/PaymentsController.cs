using Factory.Strategy.Pattern.Factory;
using Microsoft.AspNetCore.Mvc;

namespace Factory.Strategy.Pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentFactory _paymentFactory;

        public PaymentsController(IPaymentFactory paymentFactory)
        {
            _paymentFactory = paymentFactory;
        }

        [HttpPost]
        public IActionResult ProcessPayment(string type, decimal amount)
        {
            var strategy = _paymentFactory.GetPaymentStrategy(type);
            var result = strategy.ProcessPayment(amount);
            return Ok(result);
        }
    }
}
