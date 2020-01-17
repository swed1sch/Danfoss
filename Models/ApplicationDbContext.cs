using Microsoft.EntityFrameworkCore;

namespace Danfoss.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<House> Houses { get; set; }
        public DbSet<WaterMeter> waterMeters { get; set; }
    }
}
