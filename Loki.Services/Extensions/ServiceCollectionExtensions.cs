using Microsoft.Extensions.DependencyInjection;

namespace Loki.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddLokiServices(this IServiceCollection services)
        {
            services.AddTransient<IImportService, ImportService>();
        }
    }
}