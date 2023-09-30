using Loki.Core.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loki.Repositories.EntityMaps.Common
{
    public class BaseEntityMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.DateCreated)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(x => x.DateModified)
                .IsRequired(false);

            builder.Property(x => x.DateDeleted)
                .IsRequired(false);

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder.HasIndex(x => x.IsDeleted);
        }
    }
}
