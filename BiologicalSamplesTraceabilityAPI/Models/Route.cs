using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class Route 
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;
        public string Acronym { get; set; } = String.Empty;
        public string Type { get; set; } = String.Empty;
        public TimeOnly? Est_arrive { get; set; }
        public bool isActive { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime? Updated_at { get; set; }

        public ICollection<RouteGroup> RouteGroups { get; set; }



    }
}
