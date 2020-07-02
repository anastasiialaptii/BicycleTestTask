using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.BicycleDbContext
{
    public class BicycleContext : DbContext
    {
        public BicycleContext(DbContextOptions<BicycleContext> options) : base(options) { }

        public DbSet<Bicycle> Bicycles { get; set; }

        //public BicycleContext() : base("BicycleConnection")
        //{
        //}

        //public BicycleContext(string connectionString)
        //   : base(connectionString)
        //{
        //}
    }
}