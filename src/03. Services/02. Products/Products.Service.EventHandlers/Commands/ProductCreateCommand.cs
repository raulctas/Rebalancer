using MediatR;

namespace Products.Service.EventHandlers.Commands
{
    public class ProductCreateCommand : INotification
    {
        public string Id { get; set; }
        public int Currency { get; set; }
    }
}
