using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_MP_Madalina.Models;

namespace Proiect_MP_Madalina.Pages.Scenete
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_MP_Madalina.Models.Proiect_MP_MadalinaContext _context;

        public CreateModel(Proiect_MP_Madalina.Models.Proiect_MP_MadalinaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AutorID"] = new SelectList(_context.Autor, "ID", "Autor_Nume");
        ViewData["TeatruID"] = new SelectList(_context.Teatru, "ID", "Teatru_Denumire");
            return Page();
        }

        [BindProperty]
        public Sceneta Sceneta { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sceneta.Add(Sceneta);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}