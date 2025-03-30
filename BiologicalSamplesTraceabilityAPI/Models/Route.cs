using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class Route 
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;
        public int RouteTypeId { get; set; }
        public TimeOnly? Est_arrive { get; set; }
        public bool isActive { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }= DateTime.Now;

        [JsonIgnore]
        public RouteType RouteType { get; set; }
        [JsonIgnore]
        public ICollection<RouteGroup> RouteGroups { get; set; }



    }
}
