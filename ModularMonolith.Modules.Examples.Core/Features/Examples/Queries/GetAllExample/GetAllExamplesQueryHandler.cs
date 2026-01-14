using AutoMapper;
using MediatR;
using ModularMonolith.Modules.Examples.Core.Contracts.Persistence;
using ModularMonolith.Modules.Examples.Core.DTOs;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Queries.GetAllExample
{
    public class GetAllExamplesQueryHandler(
        IExampleRepository appointmentRepository,
        IMapper mapper) : IRequestHandler<GetAllExamplesQuery, IEnumerable<GetAllExamplesDto>>
    {
        private readonly IExampleRepository _appointmentRepository = appointmentRepository;
        private readonly IMapper _mapper = mapper;
        public async Task<IEnumerable<GetAllExamplesDto>> Handle(GetAllExamplesQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<IEnumerable<GetAllExamplesDto>>(await _appointmentRepository.GetListAsync(cancellationToken: cancellationToken));

            //otra variante utilizando select
            return [.. await _appointmentRepository.GetListAsync(
                select: x => new GetAllExamplesDto 
                {
                }
                ,cancellationToken: cancellationToken)];
        }
    }
}
