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

        /// <summary>
        /// Reads animal data from csv file and converts it 
        /// to a list of animal entities
        /// </summary>
        /// <returns>List of animal entities</returns>
        private static List<AnimalEntity> ImportAnimals()
        {
            using var reader = new StreamReader("C:\\Users\\kaist\\Desktop\\data\\animals.csv");

            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var animalRecords = csv.GetRecords<AnimalImportModel>().ToList();

            var columnHeaders = csv.HeaderRecord; // CSV Column Headers i.e Name, Continents, Habitat

            var animals = animalRecords.ConvertAll(x => new AnimalEntity
            {
                Name = x.Name,
                Continents = x.Continents.Split(',').ToList(),
                Habitat = x.Habitat.Split(",").ToList(),
                Food = x.Food.Split(",").ToList(),
            });

            // Alternative method using a loop
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
