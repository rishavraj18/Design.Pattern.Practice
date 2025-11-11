using Abstract.Factory.Design.Pattern.AbstractFactory;
using Abstract.Factory.Design.Pattern.AbstractProducts;
using Abstract.Factory.Design.Pattern.ConcreteProducts;

namespace Abstract.Factory.Design.Pattern.ConcreteFactory
{
    public class OnPremiseEnvironmentFactory : IEnvironmentFactory
    {
        public IRepository CreateRepository() => new OnPremiseRepository();
        public ILoggerService CreateLogger() => new OnPremiseLogger();
    }
}
