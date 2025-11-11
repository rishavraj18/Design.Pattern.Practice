using Abstract.Factory.Design.Pattern.AbstractProducts;

namespace Abstract.Factory.Design.Pattern.AbstractFactory
{
    public interface IEnvironmentFactory
    {
        IRepository CreateRepository();
        ILoggerService CreateLogger();
    }
}
