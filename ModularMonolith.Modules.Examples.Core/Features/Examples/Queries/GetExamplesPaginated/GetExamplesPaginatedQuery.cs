using MediatR;
using Examples.Core.Models;
using ModularMonolith.Modules.Examples.Core.DTOs;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.GetExamplesPaginated
{
    public record GetExamplesPaginatedQuery(
        int CurrentPage,
        int PageSize
    ) : IRequest<PagedResult<GetExamplesPaginatedDto>>;
}
