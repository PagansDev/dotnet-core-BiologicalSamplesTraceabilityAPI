using System.ComponentModel.DataAnnotations;

namespace BiologicalSamplesTraceability.Core.Entities
{
    public class Checkpoint : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int Position { get; set; }
        public long? RoutineId { get; set; }

        public Routine Routine { get; set; }
        public ICollection<Traceability> Traceabilities { get; set; }
    }
}
