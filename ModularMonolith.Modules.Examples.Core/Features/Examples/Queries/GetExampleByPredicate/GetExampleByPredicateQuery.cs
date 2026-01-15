using MediatR;
using ModularMonolith.Modules.Examples.Core.DTOs;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.GetExampleByPredicate
{
    public record GetExampleByPredicateQuery(
        int Id
    ) : IRequest<GetExampleByPredicateDto?>;
}
