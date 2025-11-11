using Abstract.Factory.Design.Pattern.AbstractFactory;
using Abstract.Factory.Design.Pattern.AbstractProducts;
using Abstract.Factory.Design.Pattern.ConcreteProducts;

namespace Abstract.Factory.Design.Pattern.ConcreteFactory
{
    public class CloudEnvironmentFactory : IEnvironmentFactory
    {
        public IRepository CreateRepository() => new CloudRepository();
        public ILoggerService CreateLogger() => new CloudLogger();
    }
}
