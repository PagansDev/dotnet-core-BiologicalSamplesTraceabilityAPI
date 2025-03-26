using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class SampleType
    {
       
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public String Name { get; set; } = String.Empty;
        
        [Required]
        public DateTime Created_at { get; set; }
        
        public DateTime? Updated_at { get; set; }
    }
}
