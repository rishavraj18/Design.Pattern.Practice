namespace CQRS.MediatR.Event_Driven.Design.Pattern.Events
{
    using global::MediatR;
    using MediatR;

    public record ProductCreatedEvent(int ProductId, string Name, decimal Price) : INotification;

}
