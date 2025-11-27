using Repository.Design.Pattern.Models;

namespace Repository.Design.Pattern.Repositories
{
    public interface IProductRepository : IGenericRepository<Products>
    {
        Task<IEnumerable<Products>> GetProductsAbovePrice(decimal price);
    }
}
