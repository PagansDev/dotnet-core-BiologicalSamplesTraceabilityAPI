using System.ComponentModel.DataAnnotations;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class Routine
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }

}
