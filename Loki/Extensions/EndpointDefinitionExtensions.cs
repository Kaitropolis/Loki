using Loki.Core;
using System.Reflection;

namespace Loki.Extensions
{
    public static class EndpointDefinitionExtensions
    {
        public static void AddEndpointDefinitions(this IServiceCollection services)
        {
            var assembly = Assembly.GetEntryAssembly();

            if (assembly is null) throw new Exception("Could not get entry assembly");

            var endpoints = assembly.ExportedTypes
                .Where(x => typeof(IEndpointDefinition).IsAssignableFrom(x)
                    && x is { IsAbstract: false, IsInterface: false })
                .Select(Activator.CreateInstance)
                .Cast<IEndpointDefinition>()
                .ToList();

            services.AddSingleton<IReadOnlyCollection<IEndpointDefinition>>(endpoints);
        }

        public static void UseEndpointDefinitions(this WebApplication app)
        {
            var definitions = app.Services.GetRequiredService<IReadOnlyCollection<IEndpointDefinition>>();

            foreach ( var definition in definitions)
            {
                definition.MapEndpoints(app);
            }
        }
    }
}
