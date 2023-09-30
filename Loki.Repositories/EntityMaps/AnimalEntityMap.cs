using Loki.Entities;
using Loki.Repositories.EntityMaps.Common;
using Loki.Repositories.Extensions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loki.Repositories.EntityMaps
{
    public class AnimalEntityMap : BaseEntityMap<AnimalEntity>
    {
        public override void Configure(EntityTypeBuilder<AnimalEntity> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Continents)
                .HasJsonConversion();

            builder.Property(x => x.Habitat)
                .HasJsonConversion();

            builder.Property(x => x.Food)
                .HasJsonConversion();
        }
    }
}
