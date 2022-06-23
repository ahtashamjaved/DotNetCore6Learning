using Microsoft.EntityFrameworkCore;
using TestProjectWeb.Models;

namespace TestProjectWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
             
        }

        public DbSet<Category> Categories { get; set; }
    }
}
