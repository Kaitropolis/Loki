using Loki.Models;
using Loki.Repositories;

namespace Loki.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IUnitOfWork unitOfWork)
        {
            _animalRepository = unitOfWork.Animals;
        }

        public async Task<AnimalsView> GetAnimals()
        {
            var animals = await _animalRepository.GetAllAsync();

            return new AnimalsView { Animals = animals };
        }
    }
}
