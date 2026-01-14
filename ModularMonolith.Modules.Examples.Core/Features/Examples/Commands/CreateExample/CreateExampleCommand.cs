using MediatR;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.CreateExample
{
    public record CreateExampleCommand(
        int Id
    ) : IRequest<int>;
}
