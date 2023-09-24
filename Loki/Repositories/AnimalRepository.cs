using Loki.Entities;

namespace Loki.Repositories
{
    public class AnimalRepository : BaseRepository<AnimalEntity>, IAnimalRepository
    {
        public AnimalRepository(LokiDbContext context) : base(context)
        {
            
        }
    }
}
