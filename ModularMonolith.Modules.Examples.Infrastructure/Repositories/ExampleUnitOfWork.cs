using ModularMonolith.BuildingBlocks.Contracts.Persistence;
using ModularMonolith.Modules.Examples.Core.Contracts.Persistence;
using ModularMonolith.Modules.Examples.Infrastructure.Persistence;

namespace ModularMonolith.Modules.Examples.Infrastructure.Repositories
{
    public class ExampleUnitOfWork(
        ExampleDbContext context,
        IExampleRepository exampleRepository
        ) : UnitOfWorkBase<ExampleDbContext>(context), IExampleUnitOfWork
    {
        public IExampleRepository Examples { get; } = exampleRepository;
    }
}