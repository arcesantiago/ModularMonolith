using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModularMonolith.BuildingBlocks.Cache;
using ModularMonolith.BuildingBlocks.Contracts.Infrastructure;
using ModularMonolith.BuildingBlocks.Contracts.Persistence;
using ModularMonolith.BuildingBlocks.Contracts.Persistence.Read;
using ModularMonolith.BuildingBlocks.Contracts.Persistence.Write;
using ModularMonolith.Modules.Examples.Core.Contracts.Persistence;
using ModularMonolith.Modules.Examples.Infrastructure.Persistence;
using ModularMonolith.Modules.Examples.Infrastructure.Repositories;

namespace ModularMonolith.Modules.Examples.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ExampleDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
                .LogTo(Console.WriteLine, [DbLoggerCategory.Database.Command.Name], Microsoft.Extensions.Logging.LogLevel.Information)
                .EnableSensitiveDataLogging());

            services.AddMemoryCache();
            services.AddScoped<ICacheService, MemoryCacheService>();

            services.AddScoped(typeof(IReadRepository<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(RepositoryBase<>));
            services.AddScoped(typeof(IQueryRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IExampleRepository, ExampleRepository>();
            services.AddScoped<IExampleUnitOfWork, ExampleUnitOfWork>();

            return services;
        }
    }
}