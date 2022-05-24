using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspWebCoreApp.Data;
using AspWebCoreApp.Models;

namespace AspWebCoreApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly AspWebCoreApp.Data.AspWebCoreAppContext _context;

        public IndexModel(AspWebCoreApp.Data.AspWebCoreAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
