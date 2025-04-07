using System.Text.Json.Serialization;

namespace BiologicalSamplesTraceability.Core.Entities
{
    public class RouteType : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        public string Acronym { get; set; } = String.Empty;

        [JsonIgnore]
        public ICollection<Route> Routes { get; set; } = null!;

    }
}
