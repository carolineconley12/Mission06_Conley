using Microsoft.EntityFrameworkCore;

namespace Mission06_Conley.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        { 
        }

        public DbSet<Application> Applications { get; set; }
    }   
}
