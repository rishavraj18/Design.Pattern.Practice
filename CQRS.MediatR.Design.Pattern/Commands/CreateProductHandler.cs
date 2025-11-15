using CQRS.MediatR.Design.Pattern.Data;
using CQRS.MediatR.Design.Pattern.Domain;
using MediatR;

namespace CQRS.MediatR.Design.Pattern.Commands
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly AppDbContext _context;

        public CreateProductHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync(cancellationToken);

            return product.Id;
        }
    }

}
