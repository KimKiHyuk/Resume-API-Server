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
        public DbSet<AboutMeModelDto> AboutMe { get; set; }
        public DbSet<CareerModelDto> Career { get; set; }
        public DbSet<EducationModelDto> Education { get; set; }
        public DbSet<ProjectModelDto> Project { get; set; }
        public DbSet<SkillModelDto> Skill { get; set; }
    }
}