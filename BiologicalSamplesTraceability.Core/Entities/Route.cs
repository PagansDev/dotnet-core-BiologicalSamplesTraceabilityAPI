using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BiologicalSamplesTraceability.Core.Entities
{
    public class Route : BaseEntity
    {
        public string Name { get; set; } = String.Empty;
        public long RouteTypeId { get; set; }
        public TimeOnly? Est_arrive { get; set; }
        public bool isActive { get; set; }

        [JsonIgnore]
        public RouteType RouteType { get; set; }
        [JsonIgnore]
        public ICollection<RouteGroup> RouteGroups { get; set; }



    }
}
