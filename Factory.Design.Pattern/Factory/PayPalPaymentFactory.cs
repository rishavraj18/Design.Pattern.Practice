using Factory.Design.Pattern.Services;

namespace Factory.Design.Pattern.Factory
{
    public class PayPalPaymentFactory : PaymentFactory
    {
        public override IPaymentProcessor CreatePaymentProcessor()
        => new PayPalPaymentProcessor();
    }
}
