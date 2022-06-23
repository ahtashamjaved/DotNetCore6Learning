#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesExamples.Models;

namespace RazorPagesExamples.Data
{
    public class RazorPagesExamplesContext : DbContext
    {
        public RazorPagesExamplesContext (DbContextOptions<RazorPagesExamplesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesExamples.Models.Movie> Movie { get; set; }
    }
}
