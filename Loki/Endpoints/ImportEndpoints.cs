using Loki.Core;
using Loki.Services;

namespace Loki.Endpoints
{
    public sealed class ImportEndpoints : IEndpointDefinition
    {
        public void MapEndpoints(IEndpointRouteBuilder app)
        {
            app.MapGet("/import", ImportAnimals);
        }

        /// <summary>
        /// Reads animal data from csv file and converts it 
        /// to a list of animal entities
        /// </summary>
        /// <returns>List of animal entities with column headers</returns>
        private static async Task<IResult> ImportAnimals(IImportService service)
        {
            await service.ImportAnimals();

            return Results.Ok();
        }
    }
}
