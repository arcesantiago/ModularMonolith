using MediatR;
using ModularMonolith.Modules.Examples.Core.Contracts.Persistence;
using ModularMonolith.Modules.Examples.Core.Entities;
using System.Linq.Expressions;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.DeleteManyExamples
{
    public class DeleteManyExamplesCommandHandler(
        IExampleUnitOfWork unitOfWork) : IRequestHandler<DeleteManyExamplesCommand, int>
    {
        private readonly IExampleUnitOfWork _unitOfWork = unitOfWork;

        public async Task<int> Handle(DeleteManyExamplesCommand request, CancellationToken cancellationToken)
        {
            Expression<Func<Example, bool>> predicate = 
                x => request.Ids.Contains(x.Id);

            var deletedCount = await _unitOfWork.Examples.DeleteManyAsync(predicate, cancellationToken);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return deletedCount;
        }
    }
}
