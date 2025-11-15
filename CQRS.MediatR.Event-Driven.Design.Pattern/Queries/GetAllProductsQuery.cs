using CQRS.MediatR.Event_Driven.Design.Pattern.Domain;
using MediatR;

namespace CQRS.MediatR.Event_Driven.Design.Pattern.Queries
{
    public record GetAllProductsQuery() : IRequest<IEnumerable<Product>>;
}
