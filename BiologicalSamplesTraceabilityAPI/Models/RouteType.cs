using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class RouteType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;
        public string Acronym { get; set; } = String.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [JsonIgnore]
        public ICollection<Route> Routes { get; set; }

    }
}
