using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public CreateModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        /// <summary>
        /// El OnGetmétodo inicializa cualquier estado necesario para la página.
        /// </summary>
        /// <returns>La página Crear no tiene ningún estado para inicializar, por lo que Page se devuelve.</returns>
        public IActionResult OnGet()
        {
            return Page();
        }

        /// <summary>
        /// La Movie propiedad utiliza el atributo [BindProperty] para optar por la vinculación del modelo.
        /// </summary>
        [BindProperty]
        public Movie Movie { get; set; }

        /// <summary>
        /// El OnPostAsyn cmétodo se ejecuta cuando la página publica datos del formulario.
        /// </summary>
        /// <returns></returns>
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
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
