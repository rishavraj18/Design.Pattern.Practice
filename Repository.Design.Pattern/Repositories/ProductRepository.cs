using Microsoft.EntityFrameworkCore;
using Repository.Design.Pattern.Data;
using Repository.Design.Pattern.Models;

namespace Repository.Design.Pattern.Repositories
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Products>> GetProductsAbovePrice(decimal price)
        {
            return await _context.Products
                .Where(p => p.Price > price)
                .ToListAsync();
        }
    }
}
