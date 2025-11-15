using MediatR;

namespace CQRS.MediatR.Design.Pattern.Commands
{  
    public record CreateProductCommand(string Name, decimal Price) : IRequest<int>;
}
