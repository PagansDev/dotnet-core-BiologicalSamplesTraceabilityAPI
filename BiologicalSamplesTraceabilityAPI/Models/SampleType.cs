using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class SampleType
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;        
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [JsonIgnore]
        public ICollection<SampleBatch> SampleBatches { get; set; }
    }
}
