using Microsoft.EntityFrameworkCore;
using ModularMonolith.Kernel.Models;
using ModularMonolith.Modules.Examples.Core.Entities;

namespace ModularMonolith.Modules.Examples.Infrastructure.Persistence
{
    public class ExampleDbContext(DbContextOptions<ExampleDbContext> options) : DbContext(options)
    {
        public DbSet<Example>? Examples { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.UtcNow;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdatedAt = DateTime.UtcNow;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
