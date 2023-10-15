using Loki.Core;
using Loki.Models;
using Loki.Services;

namespace Loki.Endpoints
{
    public class AnimalEndpoints : IEndpointDefinition
    {
        public void MapEndpoints(IEndpointRouteBuilder app)
        {
            app.MapGet("/animals", GetAnimals);
        }

        /// <summary>
        /// Reads animal data from csv file and converts it 
        /// to a list of animal entities
        /// </summary>
        /// <returns>List of animal entities with column headers</returns>
        private static async Task<AnimalsView> GetAnimals(IAnimalService service)
        {
            var animalsView = await service.GetAnimals();

            return animalsView;
        }
    }
}
