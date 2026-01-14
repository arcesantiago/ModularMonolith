using ModularMonolith.Kernel.Models;

namespace ModularMonolith.BuildingBlocks.Contracts.Persistence.Write
{
    public interface IWriteRepository<T> where T : BaseDomainModel
    {
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
    }
}
