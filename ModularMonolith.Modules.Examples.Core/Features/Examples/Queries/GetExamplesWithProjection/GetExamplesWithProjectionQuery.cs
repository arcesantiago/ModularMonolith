using MediatR;
using ModularMonolith.Modules.Examples.Core.DTOs;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.GetExamplesWithProjection
{
    public record GetExamplesWithProjectionQuery : IRequest<IEnumerable<GetExamplesWithProjectionDto>>;
}
