using MediatR;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.UpdateExample
{
    public record UpdateExampleCommand(
        int Id
    ) : IRequest<int>;
}
