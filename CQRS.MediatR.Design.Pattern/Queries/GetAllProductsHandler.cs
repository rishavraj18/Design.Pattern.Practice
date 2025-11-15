using CQRS.MediatR.Design.Pattern.Data;
using CQRS.MediatR.Design.Pattern.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.MediatR.Design.Pattern.Queries
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly AppDbContext _context;

        public GetAllProductsHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.AsNoTracking().ToListAsync(cancellationToken);
        }
    }

}
