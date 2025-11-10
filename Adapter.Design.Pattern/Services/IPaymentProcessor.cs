namespace Adapter.Design.Pattern.Services
{
    public interface IPaymentProcessor
    {
        Task<bool> ProcessPayment(decimal amount);
    }
}
