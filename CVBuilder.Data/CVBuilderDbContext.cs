using CVBuilder.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CVBuilder.API.Data
{
    public class CVBuilderDbContext : IdentityDbContext<User>
    {
        public CVBuilderDbContext(DbContextOptions<CVBuilderDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProjectsDbEntity> ProjectsDbEntities { get; set; }
        public DbSet<EducationDbEntity> EducationDbEntities { get; set; }
        public DbSet<ExperienceDbEntity> ExperienceDbEntities { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Award> Awards { get; set; }

    }
}