using BicycleTaskApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BicycleTaskApi.BicycleDbContext
{
    public class BicycleContext : DbContext
    {
        public BicycleContext(DbContextOptions<BicycleContext> options) : base(options) { }

        public DbSet<Bicycle> Bicycles { get; set; }
    }
}
