using MediatR;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.UpdateManyExamples
{
    public record UpdateManyExamplesCommand(
        int[] Ids
    ) : IRequest<int>;
}
