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
        public DbSet<CV> CVs { get; set; }
    }
}