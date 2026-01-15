using MediatR;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.CountExamples
{
    public record CountExamplesQuery : IRequest<int>;
}
