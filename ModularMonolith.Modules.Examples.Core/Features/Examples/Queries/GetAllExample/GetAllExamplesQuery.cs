using MediatR;
using ModularMonolith.Modules.Examples.Core.DTOs;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.GetAllExample
{
    public record GetAllExamplesQuery : IRequest<IEnumerable<GetAllExamplesDto>>;
}
