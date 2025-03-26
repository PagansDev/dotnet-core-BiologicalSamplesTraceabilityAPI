using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class Route 
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(3)]
        public string Acronym { get; set; }

        [MaxLength(30)]
        public string? Type { get; set; }

        [Required]
        public TimeOnly? Est_arrive { get; set; }

        [Required]
        public bool isActive { get; set; }

        [Required]
        public DateTime Created_at { get; set; }

        public DateTime? Updated_at { get; set; }



    }
}
