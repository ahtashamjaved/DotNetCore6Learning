#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesExamples.Data;
using RazorPagesExamples.Models;

namespace RazorPagesExamples.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesExamples.Data.RazorPagesExamplesContext _context;

        public IndexModel(RazorPagesExamples.Data.RazorPagesExamplesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
