
namespace BiologicalSamplesTraceability.Core.Entities
{
    public class Traceability : BaseEntity
    {
        
        public long BatchIdentifierId { get; set; }
        public long CheckpointId { get; set; }
        public DateTime Timestamp { get; set; }


        public BatchIdentifier BatchIdentifier { get; set; }
        public Checkpoint Checkpoint { get; set; }


    }
}
