using CsvHelper;
using Loki.Entities;
using Loki.Models;
using System.Globalization;

namespace Loki.Endpoints
{
    public static class ImportEndpoints
    {
        public static void MapImportEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/import", ImportAnimals);
        }

        private static List<AnimalEntity> ImportAnimals()
        {
            using var reader = new StreamReader("C:\\Users\\kaist\\Desktop\\data\\animals.csv");

            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var animalRecords = csv.GetRecords<AnimalImportModel>().ToList();

            // TODO: Convert records into a list of type AnimalEntity.
            // Notice that the 3 comma separated strings Continents, Habitat and Food
            // need to be converted to proper lists.
            // Once converted, simply return the new list from this endpoint.            

            var animals = animalRecords.ConvertAll(x => new AnimalEntity
            {
                Name = x.Name,
                Continents = x.Continents.Split(',').ToList(),
                Habitat = x.Habitat.Split(",").ToList(),
                Food = x.Food.Split(",").ToList(),
            });

            // Alternative method
            var animals2 = new List<AnimalEntity>();

            foreach (var record in animalRecords)
            {
                var animal = new AnimalEntity
                {
                    Name = record.Name,
                    Continents = record.Continents.Split(',').ToList(),
                    Habitat = record.Habitat.Split(",").ToList(),
                    Food = record.Food.Split(",").ToList(),
                };

                animals2.Add(animal);
            }

            return animals;
        }
    }
}
