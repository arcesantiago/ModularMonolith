using MediatR;
using ModularMonolith.Modules.Examples.Core.DTOs;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.GetExampleById
{
    public record GetExampleByIdQuery(
        int Id
    ) : IRequest<GetExampleByIdDto?>;
}
