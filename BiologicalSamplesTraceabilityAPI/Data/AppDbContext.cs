using BiologicalSamplesTraceabilityAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BiologicalSamplesTraceabilityAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<SampleBatch> SampleBatches { get; set; }
        public DbSet<BatchIdentifier> BatchIdentifiers { get; set; }
        public DbSet<SampleType> SampleTypes { get; set; }
        public DbSet<Models.Route> Routes { get; set; }
        public DbSet<RouteGroup> RouteGroups { get; set; }
        public DbSet<Traceability> Traceabilities { get; set; }
        public DbSet<Checkpoint> Checkpoints { get; set; }
        public DbSet<Routine> Routines { get; set; }

        public DbSet<RouteType> RouteTypes { get; set; }
             


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SampleBatch>()
                .HasOne(sb => sb.SampleType)
                .WithMany(st => st.SampleBatches)
                .HasForeignKey(sb => sb.SampleTypeId);

            modelBuilder.Entity<BatchIdentifier>()
                .HasOne(bi => bi.SampleBatch)
                .WithOne(sb => sb.BatchIdentifier)
                .HasForeignKey<BatchIdentifier>(bi => bi.SampleBatchId);

            modelBuilder.Entity<RouteGroup>()
                .HasOne(rg => rg.SampleBatch)
                .WithMany(sb => sb.RouteGroups)
                .HasForeignKey(rg => rg.SampleBatchId);

            modelBuilder.Entity<RouteGroup>()
                .HasOne(rg => rg.Route)
                .WithMany(r => r.RouteGroups)
                .HasForeignKey(rg => rg.RouteId);

            modelBuilder.Entity<Models.Route>()
                .HasOne(r => r.RouteType)
                .WithMany(rt => rt.Routes)
                .HasForeignKey(r => r.RouteTypeId);

            modelBuilder.Entity<Traceability>()
                .HasOne(t => t.BatchIdentifier)
                .WithMany(bi => bi.Traceabilities)
                .HasForeignKey(t => t.BatchIdentifierId);

            modelBuilder.Entity<Traceability>()
                .HasOne(t => t.Checkpoint)
                .WithMany(cp => cp.Traceabilities)
                .HasForeignKey(t => t.CheckpointId);

            modelBuilder.Entity<Checkpoint>()
                .HasOne(cp => cp.Routine)
                .WithMany()
                .HasForeignKey(cp => cp.RoutineId);

      
        }



    }
}
