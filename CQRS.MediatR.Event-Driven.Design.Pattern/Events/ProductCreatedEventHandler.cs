using MediatR;

namespace CQRS.MediatR.Event_Driven.Design.Pattern.Events
{
    public class ProductCreatedEventHandler : INotificationHandler<ProductCreatedEvent>
    {
        public async Task Handle(ProductCreatedEvent notification, CancellationToken cancellationToken)
        {
            // Simulate async side effect (email, cache, etc.)
            await Task.Delay(300);

            Console.WriteLine($"📢 Product Created Event Triggered: {notification.Name} (${notification.Price})");
            // You can have multiple event handlers listening to the same event — they will all be triggered independently.
            // - Send an email
            // - Push a message to Kafka/RabbitMQ
            // - Update Redis cache
            // - Write to an audit log
        }
    }
}
