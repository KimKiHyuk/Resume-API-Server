using APIServer.Model;
using Microsoft.EntityFrameworkCore;

namespace APIServer.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: set default value
        }

        public DbSet<BaseJsonModel> AboutMe { get; set; }    
        public DbSet<BaseJsonModel> Career { get; set; }
    }
}