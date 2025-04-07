using System.ComponentModel.DataAnnotations;

namespace BiologicalSamplesTraceability.Core.Entities
{
    public class BaseEntity
    {

        [Key]
        public long Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
