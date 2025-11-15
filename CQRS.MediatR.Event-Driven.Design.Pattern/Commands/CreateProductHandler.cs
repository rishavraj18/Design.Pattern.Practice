using CQRS.MediatR.Event_Driven.Design.Pattern.Data;
using CQRS.MediatR.Event_Driven.Design.Pattern.Domain;
using CQRS.MediatR.Event_Driven.Design.Pattern.Events;
using MediatR;

namespace CQRS.MediatR.Event_Driven.Design.Pattern.Commands
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly AppDbContext _context;
        private readonly IMediator _mediator;

        public CreateProductHandler(AppDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
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

            // 🔔 Publish event after creation
            await _mediator.Publish(new ProductCreatedEvent(product.Id, product.Name, product.Price), cancellationToken);

            return product.Id;
        }
    }

}
