using System.ComponentModel.DataAnnotations;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class BatchIdentifier
    {

        [Key]
        public int Id { get; set; }

        public string Code { get; set; } = String.Empty;
        public string Print { get; set; } = String.Empty;
        public int SampleBatchId { get; set; }
        public DateTime CreatedAt { get; set;}
        public DateTime UpdatedAt { get; set;}

        public SampleBatch SampleBatch { get; set; }
        public ICollection<Traceability> Traceabilities { get; set; }

    }
}
