using Microsoft.EntityFrameworkCore;

namespace DatingAPI.Entities
{
    public class DomainContext : DbContext
    {
        public DomainContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}
