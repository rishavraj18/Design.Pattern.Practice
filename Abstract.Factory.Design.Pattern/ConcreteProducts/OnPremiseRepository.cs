using Abstract.Factory.Design.Pattern.AbstractProducts;

namespace Abstract.Factory.Design.Pattern.ConcreteProducts
{
    public class OnPremiseRepository : IRepository
    {
        public string GetData() => "Data from On-Premise DB";
    }
}
