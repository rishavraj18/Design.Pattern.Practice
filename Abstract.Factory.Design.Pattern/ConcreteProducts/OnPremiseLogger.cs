using Abstract.Factory.Design.Pattern.AbstractProducts;

namespace Abstract.Factory.Design.Pattern.ConcreteProducts
{
    public class OnPremiseLogger : ILoggerService
    {
        public void Log(string message) => Console.WriteLine($"[OnPrem Log] {message}");
    }
}
