using Casgem_mediator.MediatorPattern.Result;
using MediatR;

namespace Casgem_mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery:IRequest<GetProductUpdateByIDQueryResult>
    {
        public GetProductUpdateByIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
