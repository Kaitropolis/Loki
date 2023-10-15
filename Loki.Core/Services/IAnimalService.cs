using Loki.Models;

namespace Loki.Services
{
    public interface IAnimalService
    {
        Task<AnimalsView> GetAnimals();
    }
}