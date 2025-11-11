namespace Factory.Design.Pattern.Services
{
    public interface IPaymentProcessor
    {
        string ProcessPayment(decimal amount);
    }
}
