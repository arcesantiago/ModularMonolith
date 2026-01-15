using MediatR;
using Microsoft.EntityFrameworkCore;
using ModularMonolith.Modules.Examples.Core.Contracts.Persistence;
using ModularMonolith.Modules.Examples.Core.Entities;
using System.Linq;

namespace ModularMonolith.Modules.Examples.Core.Features.Examples.Commands.UpdateManyExamples
{
    public class UpdateManyExamplesCommandHandler(
        IExampleUnitOfWork unitOfWork) : IRequestHandler<UpdateManyExamplesCommand, int>
    {
        private readonly IExampleUnitOfWork _unitOfWork = unitOfWork;

        public async Task<int> Handle(UpdateManyExamplesCommand request, CancellationToken cancellationToken)
        {
            Func<IQueryable<Example>, IQueryable<Example>> filter = query => query.Where(x => request.Ids.Contains(x.Id));

            Func<IQueryable<Example>, Task<int>> updateAction = async query =>
            {
                var examples = await query.ToListAsync(cancellationToken);
                foreach (var example in examples)
                {
                    // En este ejemplo, no hay campos que actualizar, pero se marca como modificado
                    _unitOfWork.Examples.Update(example);
                }
                return examples.Count;
            };

            var updatedCount = await _unitOfWork.Examples.UpdateManyAsync(filter, updateAction);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return updatedCount;
        }
    }
}
