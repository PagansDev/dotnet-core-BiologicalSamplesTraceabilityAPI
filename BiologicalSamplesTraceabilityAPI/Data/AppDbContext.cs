using Microsoft.EntityFrameworkCore;

namespace BiologicalSamplesTraceabilityAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

       

    }
}
