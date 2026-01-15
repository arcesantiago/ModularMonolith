using MediatR;
using Examples.Core.Exceptions;
using ModularMonolith.Modules.Examples.Core.Contracts.Persistence;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.DeleteExample
{
    public class DeleteExampleCommandHandler(
        IExampleUnitOfWork unitOfWork) : IRequestHandler<DeleteExampleCommand, int>
    {
        private readonly IExampleUnitOfWork _unitOfWork = unitOfWork;

        public async Task<int> Handle(DeleteExampleCommand request, CancellationToken cancellationToken)
        {
            var example = await _unitOfWork.Examples.FindAsync(request.Id, cancellationToken);

            if (example == null)
                throw new NotFoundException(nameof(example), request.Id);

            _unitOfWork.Examples.Delete(example);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return request.Id;
        }
    }
}
