using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Soz.Data.Entities;

namespace Soz.Migrations
{
public class SozDbContext : IdentityDbContext<User> 
{
        public SozDbContext(DbContextOptions<SozDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<JobSeeker> JobSeekers { get; set; }
    }
}
 
 