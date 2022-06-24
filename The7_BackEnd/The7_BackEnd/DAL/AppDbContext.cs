using Microsoft.EntityFrameworkCore;
using The7_BackEnd.Models;

namespace The7_BackEnd.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
       public DbSet<PageIntro> PageIntro { get; set; }
       public DbSet<Service> Service { get; set; }
       public DbSet<Blog> Blog { get; set; }
       public DbSet<Team> Team { get; set; }
    }
}
