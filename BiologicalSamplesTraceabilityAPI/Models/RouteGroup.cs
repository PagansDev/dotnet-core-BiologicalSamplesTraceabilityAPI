using System.ComponentModel.DataAnnotations;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class RouteGroup
    {
        [Key]
        public int Id { get; set; }
        public int SampleBatchId { get; set; }
        public int RouteId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        public SampleBatch SampleBatch { get; set; }
        public Route Route { get; set; }

    }
}
