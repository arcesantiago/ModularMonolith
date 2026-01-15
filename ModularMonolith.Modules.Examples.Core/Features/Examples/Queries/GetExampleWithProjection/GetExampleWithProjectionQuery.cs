using MediatR;
using ModularMonolith.Modules.Examples.Core.DTOs;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.GetExampleWithProjection
{
    public record GetExampleWithProjectionQuery(
        int Id
    ) : IRequest<GetExampleWithProjectionDto?>;
}
