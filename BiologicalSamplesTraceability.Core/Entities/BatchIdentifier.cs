using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BiologicalSamplesTraceability.Core.Entities
{
    public class BatchIdentifier : BaseEntity
    {
        public string Code { get; set; } = String.Empty;
        public string Print { get; set; } = String.Empty;
        public long SampleBatchId { get; set; }

        public SampleBatch SampleBatch { get; set; }

        [JsonIgnore]
        public ICollection<Traceability> Traceabilities { get; set; }

    }
}
