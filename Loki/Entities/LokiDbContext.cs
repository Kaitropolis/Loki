using Microsoft.EntityFrameworkCore;

namespace Loki.Entities
{
    public class LokiDbContext : DbContext
    {
        public DbSet<AnimalEntity> Animals { get; set; }
    }
}
