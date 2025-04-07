
using System.Text.Json.Serialization;

namespace BiologicalSamplesTraceability.Core.Entities
{


    public class SampleType : BaseEntity
    {
        
        public String Name { get; set; } = String.Empty;

        [JsonIgnore]
        public ICollection<SampleBatch> SampleBatches { get; set; }
    }



}
