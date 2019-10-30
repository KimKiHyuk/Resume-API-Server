using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
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
        }
        public DbSet<AboutMeDomainModel> AboutMe { get; set; }
        public DbSet<CareerDomainModel> Career { get; set; }
        public DbSet<EducationDomainModel> Education { get; set; }
        public DbSet<ProjectDomainModel> Project { get; set; }
        public DbSet<SkillDomainModel> Skill { get; set; }
    }
}