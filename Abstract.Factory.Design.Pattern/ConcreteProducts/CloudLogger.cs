using Abstract.Factory.Design.Pattern.AbstractProducts;

namespace Abstract.Factory.Design.Pattern.ConcreteProducts
{
    public class CloudLogger : ILoggerService
    {
        public void Log(string message) => Console.WriteLine($"[Cloud Log] {message}");

    }
}
