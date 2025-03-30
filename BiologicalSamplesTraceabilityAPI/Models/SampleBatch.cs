using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class SampleBatch
    {
        [Key]
        public int Id { get; set; }

        public int RouteGroupId { get; set; }
        public string Status { get; set; } = String.Empty;
        public string Shift { get; set; } = String.Empty;
        public string ClientType { get; set; } = String.Empty;
        public string ConditioningType { get; set; } = String.Empty;
        public int SampleTypeId     { get; set; }
        public decimal Temperature { get; set; }
        public decimal TraySize { get; set; } 
        public string Driver { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public SampleType SampleType { get; set; }
        public ICollection<RouteGroup> RouteGroups { get; set; }
        public BatchIdentifier BatchIdentifier { get; set; }



    }
}
