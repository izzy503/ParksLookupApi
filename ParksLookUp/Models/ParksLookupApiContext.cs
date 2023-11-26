using Microsoft.EntityFrameworkCore;

namespace ParkLookupApi.Models
{
  public class ParkLookupApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParkLookupApiContext(DbContextOptions<ParkLookupApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Yellowstone National Park", Location = "United States", Climate = "subarctic" },
          new Park { ParkId = 2, Name = "Grand Canyon National Park", Location = "United States", Climate = "subarctic" },
          new Park { ParkId = 3, Name = "Great Smoky Mountains National Park", Location = "South Africa", Climate = "subtropical" },
          new Park { ParkId = 4, Name = "Yosemites National Park", Location = "United States", Climate = "mediterranean" },
          new Park { ParkId = 5, Name = "El Yunque National Park", Location = "Puerto Rico", Climate = "temperate" }
        );
    }
  }
}