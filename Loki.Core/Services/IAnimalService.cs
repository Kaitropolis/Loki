using Loki.Entities;
using Loki.Models;

namespace Loki.Services
{
    public interface IAnimalService
    {
        Task<AnimalsView> GetAnimalsView();
        Task<AnimalEntity> GetAnimalDetails(int id);
    }
}