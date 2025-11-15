using CQRS.MediatR.Design.Pattern.Domain;
using MediatR;

namespace CQRS.MediatR.Design.Pattern.Queries
{
    public record GetAllProductsQuery() : IRequest<IEnumerable<Product>>;
}
