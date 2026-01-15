using MediatR;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.ExistsExample
{
    public record ExistsExampleQuery(
        int Id
    ) : IRequest<bool>;
}
