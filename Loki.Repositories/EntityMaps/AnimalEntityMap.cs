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

            builder
                .Property(x => x.Continents)
                .IsRequired()
                .HasJsonConversion();

            builder
                .Property(x => x.Habitat)
                .IsRequired()
                .HasJsonConversion();

            builder
                .Property(x => x.Food)
                .IsRequired()
                .HasJsonConversion();

            builder
                .Property(x => x.Health)
                .IsRequired()
                .HasAnnotation("CheckConstraint", "CHECK (Health >= 1 AND Health <= 100)");

            builder
                .Property(x => x.Attack)
                .IsRequired()
                .HasAnnotation("CheckConstraint", "CHECK (Attack >= 1 AND Attack <= 100)");

            builder
                .Property(x => x.Defence)
                .IsRequired()
                .HasAnnotation("CheckConstraint", "CHECK (Defence >= 1 AND Defence <= 100)");

            builder
                .Property(x => x.Speed)
                .IsRequired()
                .HasAnnotation("CheckConstraint", "CHECK (Speed >= 1 AND Speed <= 100)");

            builder
                .Property(x => x.Stamina)
                .IsRequired()
                .HasAnnotation("CheckConstraint", "CHECK (Stamina >= 1 AND Stamina <= 100)");

            builder
                .Property(x => x.Intelligence)
                .IsRequired()
                .HasAnnotation("CheckConstraint", "CHECK (Intelligence >= 1 AND Intelligence <= 100)");
        }
    }
}
