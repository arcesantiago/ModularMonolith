using ModularMonolith.Kernel.Models;
using System.Linq.Expressions;

namespace ModularMonolith.BuildingBlocks.Contracts.Persistence.Read
{
    public interface IQueryRepository<T>
            where T : BaseDomainModel
    {
        Task<IReadOnlyList<TResult>> GetListAsync<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            CancellationToken cancellationToken = default);

        Task<TResult?> GetAsync<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> predicate,
            CancellationToken cancellationToken = default);
    }
}
