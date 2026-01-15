using MediatR;
using ModularMonolith.Modules.Examples.Core.Contracts.Persistence;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.CountExamples
{
    public class CountExamplesQueryHandler(
        IExampleRepository exampleRepository
        ) : IRequestHandler<CountExamplesQuery, int>
    {
        private readonly IExampleRepository _exampleRepository = exampleRepository;

        public async Task<int> Handle(CountExamplesQuery request, CancellationToken cancellationToken)
        {
            return await _exampleRepository.CountAsync(cancellationToken);
        }
    }
}
