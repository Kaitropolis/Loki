using Loki.Entities;
using Loki.Repositories.Configuration;
using Loki.Repositories.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Loki.Repositories.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLokiRepositories(this IServiceCollection services, string? connectionString)
        {
            ArgumentNullException.ThrowIfNull(connectionString);

            services.AddDbContext<LokiDbContext>(options =>
            {
                options.UseSqlServer(connectionString, sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(12, TimeSpan.FromSeconds(12), null);
                });
            });

            services.AddTransient<ILokiConnectionFactory>(_ => new LokiConnectionFactory(connectionString));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddHostedService<DatabaseService>();

            return services;
        }
    }
}
