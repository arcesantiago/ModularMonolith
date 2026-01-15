using MediatR;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.DeleteManyExamples
{
    public record DeleteManyExamplesCommand(
        int[] Ids
    ) : IRequest<int>;
}
