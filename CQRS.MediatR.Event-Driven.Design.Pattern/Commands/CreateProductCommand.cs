using MediatR;

namespace CQRS.MediatR.Event_Driven.Design.Pattern.Commands
{  
    public record CreateProductCommand(string Name, decimal Price) : IRequest<int>;
}
