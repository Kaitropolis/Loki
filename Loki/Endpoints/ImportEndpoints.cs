using CsvHelper;
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

        private static List<AnimalImportModel> ImportAnimals()
        {
            using var reader = new StreamReader("C:\\Users\\kaist\\Desktop\\data\\animals.csv");

            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<AnimalImportModel>().ToList();

            // TODO: Convert records into a list of type AnimalEntity.
            // Notice that the 3 comma separated strings Continents, Habitat and Food
            // need to be converted to proper lists.
            // Once converted, simply return the new list from this endpoint.

            return records;
        }
    }
}
