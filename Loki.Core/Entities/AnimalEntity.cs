using Loki.Core.Entities.Common;

namespace Loki.Entities
{
    public class AnimalEntity : BaseEntity
    {
        public required string Name { get; set; }

        public required List<string> Continents { get; set; }

        public required List<string> Habitat { get; set; }

        public required List<string> Food { get; set; }

        public int Health { get; set; }

        public int Attack { get; set; }

        public int Defence { get; set; }

        public int Speed { get; set; }

        public int Stamina { get; set; }

        public int Intelligence { get; set; }
    }
}
