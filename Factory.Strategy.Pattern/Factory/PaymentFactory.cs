using Factory.Strategy.Pattern.Strategy;

namespace Factory.Strategy.Pattern.Factory
{
    public class PaymentFactory : IPaymentFactory
    {
        private readonly IEnumerable<IPaymentStrategy> _paymentStrategies;

        public PaymentFactory(IEnumerable<IPaymentStrategy> paymentStrategies)
        {
            _paymentStrategies = paymentStrategies;
        }

        public IPaymentStrategy GetPaymentStrategy(string type)
        {
            var strategy = _paymentStrategies.FirstOrDefault(
                s => s.PaymentType.Equals(type, StringComparison.OrdinalIgnoreCase));

            if (strategy == null)
                throw new ArgumentException($"Unsupported payment type: {type}");

            return strategy;
        }
    }
}
