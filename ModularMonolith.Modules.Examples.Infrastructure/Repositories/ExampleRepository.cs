using ModularMonolith.BuildingBlocks.Contracts.Persistence;
using ModularMonolith.Modules.Examples.Core.Contracts.Persistence;
using ModularMonolith.Modules.Examples.Core.Entities;
using ModularMonolith.Modules.Examples.Infrastructure.Persistence;

namespace ModularMonolith.Modules.Examples.Infrastructure.Repositories
{
    public class ExampleRepository(ExampleDbContext context) : RepositoryBase<Example>(context), IExampleRepository
    {
    }
}