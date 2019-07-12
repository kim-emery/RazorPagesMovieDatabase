using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FirstNetCoreWebApp.Models;

namespace FirstNetCoreWebApp.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly FirstNetCoreWebApp.Models.FirstNetCoreWebAppContext _context;

        public CreateModel(FirstNetCoreWebApp.Models.FirstNetCoreWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet() //initialises any state needed for the page. create page doesnt need any so Page is returned
        {
            return Page(); // the Page method creates a PageResult object that renders the Create.cshtml page
        }

        [BindProperty] // Movie property below uses the BindProperty attribute to opt-in model binding (turn it on), when Create form posts the form values, the ASP.NET core runtime binds the posted values to the Movie model/
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnPostAsync() // OnPostAsyn method is urn when the pages posts form dara
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}