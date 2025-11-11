using Abstract.Factory.Design.Pattern.AbstractProducts;

namespace Abstract.Factory.Design.Pattern.ConcreteProducts
{
    public class CloudRepository : IRepository
    {
        public string GetData() => "Data from Azure Cloud DB";
    }
}
