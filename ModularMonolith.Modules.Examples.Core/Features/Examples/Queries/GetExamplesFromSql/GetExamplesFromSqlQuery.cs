using MediatR;
using ModularMonolith.Modules.Examples.Core.DTOs;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.GetExamplesFromSql
{
    public record GetExamplesFromSqlQuery(
        string Sql
    ) : IRequest<IEnumerable<GetExamplesFromSqlDto>>;
}
