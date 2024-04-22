using Microsoft.EntityFrameworkCore;
namespace EArauz.Models 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Arauz> Arauz { get; set; }
        public DbSet<Carrera> Carrera { get; set; }
    }
}
