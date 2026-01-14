using Microsoft.EntityFrameworkCore;

namespace ModularMonolith.BuildingBlocks.Contracts.Persistence
{
    public abstract class UnitOfWorkBase<TContext>(TContext context) : IDisposable where TContext : DbContext
    {
        protected readonly TContext _context = context;
        public virtual async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) => await _context.SaveChangesAsync(cancellationToken);
        public void Dispose() => _context.Dispose();
    }
}