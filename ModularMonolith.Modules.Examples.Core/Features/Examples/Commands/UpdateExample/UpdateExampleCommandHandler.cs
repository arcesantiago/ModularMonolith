using MediatR;
using Examples.Core.Exceptions;
using ModularMonolith.Modules.Examples.Core.Contracts.Persistence;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.UpdateExample
{
    public class UpdateExampleCommandHandler(
        IExampleUnitOfWork unitOfWork) : IRequestHandler<UpdateExampleCommand, int>
    {
        private readonly IExampleUnitOfWork _unitOfWork = unitOfWork;

        public async Task<int> Handle(UpdateExampleCommand request, CancellationToken cancellationToken)
        {
            var example = await _unitOfWork.Examples.FindAsync(request.Id, cancellationToken);

            if (example == null)
                throw new NotFoundException(nameof(example), request.Id);

            _unitOfWork.Examples.Update(example);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return example.Id;
        }
    }
}
