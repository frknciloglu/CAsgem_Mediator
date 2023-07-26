using Casgem_mediator.MediatorPattern.Result;
using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System.Collections.Generic;

namespace Casgem_mediator.MediatorPattern.Queries
{
    public class GetProductQuery:IRequest<List<GetProductQueryResult>>
    {

    }
}
