using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class BatchIdentifier
    {

        [Key]
        public int Id { get; set; }

        public string Code { get; set; } = String.Empty;
        public string Print { get; set; } = String.Empty;
        public int SampleBatchId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public SampleBatch SampleBatch { get; set; }

        [JsonIgnore]
        public ICollection<Traceability> Traceabilities { get; set; }

    }
}
