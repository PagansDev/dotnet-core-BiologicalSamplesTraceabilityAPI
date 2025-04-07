using System.ComponentModel.DataAnnotations;

namespace BiologicalSamplesTraceability.Core.Entities
{
    public class RouteGroup : BaseEntity
    {
        public long SampleBatchId { get; set; }
        public long RouteId { get; set; }


        public SampleBatch SampleBatch { get; set; }
        public Route Route { get; set; }

    }
}
