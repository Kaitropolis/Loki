using CsvHelper;
using Loki.Entities;
using Loki.Models;
using Loki.Repositories;
using System.Globalization;

namespace Loki.Services
{
    public class ImportService : IImportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAnimalRepository _animalRepository;

        public ImportService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _animalRepository = unitOfWork.Animals;
        }

        public async Task ImportAnimals()
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

            await _animalRepository.AddRangeAsync(animals);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
