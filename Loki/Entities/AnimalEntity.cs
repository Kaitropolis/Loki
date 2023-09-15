namespace Loki.Entities
{
    public class AnimalEntity
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required List<string> Continents { get; set; }

        public required List<string> Habitat { get; set; }

        public required List<string> Food { get; set; }
    }
}
