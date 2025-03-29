using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class RouteType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;
        public string Acronym { get; set; } = String.Empty;

        [JsonIgnore]
        public ICollection<Route> Routes { get; set; }

    }
}
