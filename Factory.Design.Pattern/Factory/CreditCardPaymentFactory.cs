using Factory.Design.Pattern.Services;

namespace Factory.Design.Pattern.Factory
{
    public class CreditCardPaymentFactory : PaymentFactory
    {
        public override IPaymentProcessor CreatePaymentProcessor()
        => new CreditCardPaymentProcessor();
    }
}
