using MediatR;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.DeleteExample
{
    public record DeleteExampleCommand(
        int Id
    ) : IRequest<int>;
}
