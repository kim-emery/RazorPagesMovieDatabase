using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstNetCoreWebApp.Models;

namespace FirstNetCoreWebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly FirstNetCoreWebApp.Models.FirstNetCoreWebAppContext _context;

        public IndexModel(FirstNetCoreWebApp.Models.FirstNetCoreWebAppContext context)
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
