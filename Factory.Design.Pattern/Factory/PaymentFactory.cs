using Factory.Design.Pattern.Services;

namespace Factory.Design.Pattern.Factory
{
    public abstract class PaymentFactory
    {
        public abstract IPaymentProcessor CreatePaymentProcessor();
    }
}
