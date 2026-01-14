using ModularMonolith.BuildingBlocks.Contracts.Persistence.Read;
using ModularMonolith.BuildingBlocks.Contracts.Persistence.Write;
using ModularMonolith.Modules.Examples.Core.Entities;

namespace ModularMonolith.Modules.Examples.Core.Contracts.Persistence
{
    public interface IExampleRepository : IReadRepository<Example>, IWriteRepository<Example>, IQueryRepository<Example>
    {
    }
}
