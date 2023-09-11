namespace Loki.Entities
{
    public class AnimalEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<string> Continents { get; set; } = new List<string>();

        public List<string> Habitat { get; set; } = new List<string>();

        public List<string> Food { get; set; } = new List<string>();
    }
}
