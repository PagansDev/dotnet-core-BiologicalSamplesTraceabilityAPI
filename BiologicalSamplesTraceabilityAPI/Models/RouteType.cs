using System.ComponentModel.DataAnnotations;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class RouteType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;
        public string Acronym { get; set; } = String.Empty;

        public ICollection<Route> Routes { get; set; }

    }
}
