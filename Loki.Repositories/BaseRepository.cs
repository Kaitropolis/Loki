using Loki.Entities;
using Microsoft.EntityFrameworkCore;

namespace Loki.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DbSet<TEntity> _entities;

        public BaseRepository(LokiDbContext context)
        {
            _entities = context.Set<TEntity>();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            return _entities.ToListAsync();
        }

        public ValueTask<TEntity?> GetAsync(int id)
        {
            return _entities.FindAsync(id);
        }
    }
}
