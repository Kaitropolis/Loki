using Loki.Entities;
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

        public async Task<AnimalsView> GetAnimalsView()
        {
            var animals = await _animalRepository.GetAllAsync();

            return new AnimalsView { Animals = animals };
        }

        public async Task<AnimalEntity> GetAnimalDetails(int id)
        {
            var animal = await _animalRepository.GetAsync(id);

            if (animal == null)  throw new Exception();

            return animal;
        }
    }
}
