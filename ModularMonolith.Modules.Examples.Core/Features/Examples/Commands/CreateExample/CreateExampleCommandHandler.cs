using AutoMapper;
using MediatR;
using ModularMonolith.Modules.Examples.Core.Contracts.Persistence;
using ModularMonolith.Modules.Examples.Core.Entities;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.CreateExample
{
    public class CreateExampleCommandHandler(
        IExampleUnitOfWork unitOfWork,
        IMapper mapper) : IRequestHandler<CreateExampleCommand, int>
    {
        private readonly IExampleUnitOfWork _unitOfWork = unitOfWork;
        private readonly IMapper _mapper = mapper;

        public async Task<int> Handle(CreateExampleCommand request, CancellationToken cancellationToken)
        {
            var example = _mapper.Map<Example>(request);

            await _unitOfWork.Examples.AddAsync(example, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return example.Id;
        }
    }
}