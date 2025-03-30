﻿using System.ComponentModel.DataAnnotations;

namespace BiologicalSamplesTraceabilityAPI.Models
{
    public class Traceability
    {
        [Key]
        public int Id { get; set; }
        public int BatchIdentifierId { get; set; }
        public int CheckpointId { get; set; }
        public DateTime Timestamp { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        public BatchIdentifier BatchIdentifier { get; set; }
        public Checkpoint Checkpoint { get; set; }


    }
}
