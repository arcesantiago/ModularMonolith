using MediatR;
using ModularMonolith.Modules.Examples.Core.Contracts.Persistence;
using ModularMonolith.Modules.Examples.Core.DTOs;
using ModularMonolith.Modules.Examples.Core.Entities;
using System.Linq.Expressions;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.GetExamplesWithProjection
{
    public class GetExamplesWithProjectionQueryHandler(
        IExampleRepository exampleRepository) : IRequestHandler<GetExamplesWithProjectionQuery, IEnumerable<GetExamplesWithProjectionDto>>
    {
        private readonly IExampleRepository _exampleRepository = exampleRepository;

        public async Task<IEnumerable<GetExamplesWithProjectionDto>> Handle(GetExamplesWithProjectionQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Example, GetExamplesWithProjectionDto>> select = x => new GetExamplesWithProjectionDto
            {
                Id = x.Id
            };

            return await _exampleRepository.GetListAsync(select, cancellationToken: cancellationToken);
        }
    }
}
