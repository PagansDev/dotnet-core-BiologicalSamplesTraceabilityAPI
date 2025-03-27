using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class SampleType
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; } = String.Empty;
        public DateTime Created_at { get; set; }        
        public DateTime? Updated_at { get; set; }

        public ICollection<SampleBatch> SampleBatches { get; set; }
    }
}
