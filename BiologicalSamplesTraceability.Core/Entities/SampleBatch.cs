using System.Text.Json.Serialization;

namespace BiologicalSamplesTraceability.Core.Entities
{
    public class SampleBatch : BaseEntity
    {
        public long RouteGroupId { get; set; }
        public string Status { get; set; } = String.Empty;
        public string Shift { get; set; } = String.Empty;
        public string ClientType { get; set; } = String.Empty;
        public string ConditioningType { get; set; } = String.Empty;
        public long SampleTypeId     { get; set; }
        public decimal Temperature { get; set; }
        public decimal TraySize { get; set; } 
        public string Driver { get; set; } = String.Empty;

        [JsonIgnore]
        public SampleType SampleType { get; set; }
        public BatchIdentifier BatchIdentifier { get; set; }
        public ICollection<RouteGroup> RouteGroups { get; set; }



    }
}
