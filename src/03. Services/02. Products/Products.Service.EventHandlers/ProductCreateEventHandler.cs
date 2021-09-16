using Catalog.Persistence.Database;
using MediatR;
using Products.Domain;
using Products.Service.EventHandlers.Commands;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Service.EventHandlers
{
    public class ProductCreateEventHandler :
        INotificationHandler<ProductCreateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ProductCreateEventHandler(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ProductCreateCommand notification, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Product
            {
                Id = notification.Id,
                Currency = notification.Currency
            });

            await _context.SaveChangesAsync();
        }
    }
}
