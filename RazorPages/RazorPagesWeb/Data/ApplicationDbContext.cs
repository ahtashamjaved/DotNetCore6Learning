using Microsoft.EntityFrameworkCore;
using RazorPagesWeb.Model;

namespace RazorPagesWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }

    }
}
