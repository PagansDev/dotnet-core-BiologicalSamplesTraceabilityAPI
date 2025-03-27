using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class SampleBatch
    {
        [Key]
        public int Id { get; set; }

        public int? RouteGroupId { get; set; }
        public string? Status { get; set; }
        public string? Shift { get; set; }
        public string? ClientType { get; set; }
        public string? ConditioningType { get; set; }
        public int SampleTypeId     { get; set; }
        public decimal Temperature { get; set; }
        public decimal TraySize { get; set; }
        public string Driver { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public SampleType SampleType { get; set; }
        public ICollection<RouteGroup> RouteGroups { get; set; }
        public BatchIdentifier BatchIdentifier { get; set; }



    }
}
