using Microsoft.EntityFrameworkCore;

namespace Loki.Entities
{
    public class LokiDbContext : DbContext
    {
        public LokiDbContext() { }

        public LokiDbContext(DbContextOptions<LokiDbContext> options) : base(options) { }

        public DbSet<AnimalEntity> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(LokiDbContext).Assembly);
        }
    }
}
