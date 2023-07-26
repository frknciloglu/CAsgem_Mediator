using MediatR;

namespace Casgem_mediator.MediatorPattern.Commands
{
    public class RemoveProductCommand:IRequest
    {
        public RemoveProductCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
