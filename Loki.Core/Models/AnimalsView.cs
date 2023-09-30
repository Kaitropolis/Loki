using Loki.Entities;

namespace Loki.Models
{
    public class AnimalsView
    {
        public required List<string> Headers { get; set; }

        public required List<AnimalEntity> Animals { get; set; }
    }
}
