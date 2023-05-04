using Microsoft.EntityFrameworkCore;

namespace AppApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
        }
    }
}

