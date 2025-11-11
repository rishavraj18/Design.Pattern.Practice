using Factory.Strategy.Pattern.Strategy;

namespace Factory.Strategy.Pattern.Factory
{
    public interface IPaymentFactory
    {
        IPaymentStrategy GetPaymentStrategy(string type);
    }
}
