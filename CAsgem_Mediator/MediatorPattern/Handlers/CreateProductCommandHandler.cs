using Casgem_mediator.DAL;
using Casgem_mediator.MediatorPattern.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_mediator.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                Name = request.Name,
                Stock = request.Stock,
                Brand = "bilinmiyor",
                Price = 0
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
