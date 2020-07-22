using Microsoft.EntityFrameworkCore;

namespace BDPDatabase
{
    public class BikeDataDbContext : DbContext
    {
        public BikeDataDbContext(DbContextOptions<BikeDataDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Contribution> Contributions { get; set; }
        public DbSet<UserContribution> UserContributions { get; set; }
    }
}