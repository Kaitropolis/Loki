using Loki.Entities;

namespace Loki.Repositories
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly LokiDbContext _context;

        public UnitOfWork(LokiDbContext context)
        {
            _context = context;
            Animals = new AnimalRepository(context);
        }

        public IAnimalRepository Animals { get; private set; }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
